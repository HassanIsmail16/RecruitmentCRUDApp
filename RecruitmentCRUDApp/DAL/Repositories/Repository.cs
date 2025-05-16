using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Data.Common;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly RecruitmentContext context;
        protected readonly string idColumnName;

        public Repository(RecruitmentContext context, string idColumnName)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.idColumnName = idColumnName;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await context.Set<TEntity>().FromSqlInterpolated($"SELECT * FROM [{typeof(TEntity).Name}] WHERE {idColumnName} = {id}").FirstOrDefaultAsync();
        }

        public async Task<int> AddAsync(TEntity entity)
        {
            // Validate inputs
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            if (string.IsNullOrWhiteSpace(idColumnName))
                throw new ArgumentException("Primary key column name not specified");

            using var connection = context.Database.GetDbConnection();
            DbTransaction transaction = null;

            try
            {
                // Open connection
                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                // Begin transaction
                transaction = await connection.BeginTransactionAsync();

                // Get entity metadata
                var entityType = context.Model.FindEntityType(typeof(TEntity));
                if (entityType == null)
                    throw new InvalidOperationException($"Entity type {typeof(TEntity).Name} not registered in DbContext");

                var tableName = entityType.GetTableName();
                var properties = entityType.GetProperties()
                    .Where(p => !p.IsKey())
                    .ToList();

                // Build parameterized SQL
                var columns = string.Join(", ", properties.Select(p => $"[{p.GetColumnName()}]"));
                var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));
                var parameters = properties.Select(p =>
                {
                    var value = p.PropertyInfo.GetValue(entity);
                    return new SqlParameter($"@{p.Name}", value ?? DBNull.Value);
                }).ToArray();

                // SQL with OUTPUT clause for the specified ID column
                var sql = $@"
            INSERT INTO [{tableName}] ({columns})
            OUTPUT INSERTED.[{idColumnName}]
            VALUES ({values})";

                // Execute command
                using var command = connection.CreateCommand();
                command.CommandText = sql;
                command.Transaction = transaction;
                command.Parameters.AddRange(parameters);

                // Debug output
                Debug.WriteLine($"Executing: {sql}");
                Debug.WriteLine($"With params: {string.Join(", ", parameters.Select(p => $"{p.ParameterName}={p.Value}"))}");

                // Get result
                var result = await command.ExecuteScalarAsync();
                if (result == null || result == DBNull.Value)
                    throw new InvalidOperationException("INSERT statement did not return an ID");

                // Commit transaction
                await transaction.CommitAsync();

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                // Rollback transaction if it exists
                if (transaction != null)
                {
                    try { await transaction.RollbackAsync(); }
                    catch { /* Rollback failed - don't mask original exception */ }
                }

                // Enhanced error information
                var errorMessage = $"Failed to insert {typeof(TEntity).Name} into {context.Model.FindEntityType(typeof(TEntity))?.GetTableName()}. ";
                errorMessage += $"PK Column: {idColumnName}. ";
                errorMessage += $"Error: {ex.Message}";

                if (ex is SqlException sqlEx)
                {
                    errorMessage += $"\nSQL Error Number: {sqlEx.Number}";
                    if (sqlEx.Number == 2627) // Unique constraint violation
                    {
                        errorMessage += "\nPossible duplicate value detected";
                    }
                }

                throw new InvalidOperationException(errorMessage, ex);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var tableName = context.Model.FindEntityType(typeof(TEntity)).GetTableName();

            var properties = context.Model.FindEntityType(typeof(TEntity))
                .GetProperties()
                .Where(p => !p.IsKey())
                .ToList();

            var setClauses = string.Join(", ",
                properties.Select(p => $"[{p.GetColumnName()}] = @{p.Name}"));

            // Create parameters list correctly
            var parameters = new List<SqlParameter>();

            // Add property parameters
            foreach (var prop in properties)
            {
                parameters.Add(new SqlParameter($"@{prop.Name}",
                    entity.GetType().GetProperty(prop.Name).GetValue(entity) ?? DBNull.Value));
            }

            // Add primary key parameter
            parameters.Add(new SqlParameter("@id",
                entity.GetType().GetProperty("Id").GetValue(entity)));

            await context.Database.ExecuteSqlRawAsync(
                $"UPDATE [{tableName}] SET {setClauses} WHERE [{idColumnName}] = @id",
                parameters); // No need for ToArray() - List<SqlParameter> is acceptable
        }

        public async Task DeleteByIdAsync(int id)
        {
            var tableName = context.Model.FindEntityType(typeof(TEntity)).GetTableName();

            await context.Database.ExecuteSqlInterpolatedAsync(
                $"DELETE FROM [{tableName}] WHERE {idColumnName} = {id}"
            );
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await GetByIdAsync(id) != null;
        }
    }
}

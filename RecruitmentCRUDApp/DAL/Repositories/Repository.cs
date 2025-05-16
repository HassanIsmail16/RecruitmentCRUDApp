using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await context.Set<TEntity>().FromSqlInterpolated($"SELECT * FROM {typeof(TEntity).Name} WHERE {idColumnName} = {id}").FirstOrDefaultAsync();
        }

        public async Task<int> AddAsync(TEntity entity)
        {
            // Get the table name for the entity
            var tableName = context.Model.FindEntityType(typeof(TEntity)).GetTableName();

            // Find all non-key properties
            var properties = context.Model.FindEntityType(typeof(TEntity))
                .GetProperties()
                .Where(p => !p.IsKey())
                .ToList();

            // Find the primary key property
            var keyProperty = context.Model.FindEntityType(typeof(TEntity))
                .GetProperties()
                .First(p => p.IsKey());

            // Build column and value lists for SQL
            var columns = string.Join(", ", properties.Select(p => $"[{p.GetColumnName()}]"));
            var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

            // Create parameters for SQL query
            var parameters = properties.Select(p =>
                new SqlParameter($"@{p.Name}", p.PropertyInfo.GetValue(entity) ?? DBNull.Value)
            ).ToArray();

            // SQL query to insert and return the ID
            var sql = $@"
                INSERT INTO {tableName} ({columns})
                OUTPUT INSERTED.[{keyProperty.GetColumnName()}]
                VALUES ({values})";

            // Execute the query and get the ID
            var result = await context.Database.ExecuteSqlRawAsync(sql, parameters);

            // If using DbContext.Database.ExecuteSqlRawAsync, we need a different approach
            // since it returns affected rows count, not the inserted ID

            // Alternative implementation using ADO.NET:
            using (var connection = context.Database.GetDbConnection())
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddRange(parameters);

                    // For SQL Server, this will return the ID
                    var newId = await command.ExecuteScalarAsync();
                    return Convert.ToInt32(newId);
                }
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
                $"DELETE FROM {tableName} WHERE {idColumnName} = {id}"
            );
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await GetByIdAsync(id) != null;
        }
    }
}

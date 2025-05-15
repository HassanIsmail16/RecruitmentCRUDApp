using Azure.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DbContext
    {
        private readonly String connectionString;

        // TODO: Configure database connection in app.config after creating the database then uncomment the connection string line
        public DbContext()
        {
            //connectionString = ConfigurationManager.ConnectionStrings["RecruitmentDB"].ConnectionString;
            //if (string.IsNullOrEmpty(connectionString))
            //{
            //    throw new ConfigurationErrorsException("Database connection string is missing or invalid");
            //}
        }

        public async Task<DataTable> ExecuteQueryAsync(
            string commandText,
            SqlParameter[] parameters = null,
            SqlTransaction transaction = null,
            CommandType commandType = CommandType.Text) // Set to CommandType.StoredProcedure if the commandText is a Stored Procedure
        {
            await using SqlConnection connection = await GetOpenConnectionAsync(transaction);
            await using SqlCommand command = CreateCommand(commandText, parameters, connection, transaction, commandType);
            using SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            await Task.Run(() => adapter.Fill(dataTable));
            return dataTable;
        }

        public async Task<object?> ExecuteScalarAsync(string sql, SqlParameter[] parameters = null, SqlTransaction transaction = null)
        {
            await using SqlConnection connection = await GetOpenConnectionAsync(transaction);
            await using SqlCommand command = CreateCommand(sql, parameters, connection, transaction);
            return await command.ExecuteScalarAsync();
        }

        public async Task<int> ExecuteNonQueryAsync(
            string commandText,
            SqlParameter[] parameters = null,
            SqlTransaction transaction = null,
            CommandType commandType = CommandType.Text) // Set to CommandType.StoredProcedure if the commandText is a Stored Procedure
        {
            await using SqlConnection connection = await GetOpenConnectionAsync(transaction);
            await using SqlCommand command = CreateCommand(commandText, parameters, connection, transaction, commandType);
            return await command.ExecuteNonQueryAsync();
        }
        public async Task<SqlTransaction> BeginTransactionAsync()
        {
            await using SqlConnection connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            return connection.BeginTransaction();
        }
        private async Task<SqlConnection> GetOpenConnectionAsync(SqlTransaction transaction)
        {
            if (transaction != null) 
            {
                return transaction.Connection;
            };

            var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            return connection;
        }

        private SqlCommand CreateCommand(
            String sql,
            SqlParameter[] parameters,
            SqlConnection connection,
            SqlTransaction transaction,
            CommandType commandType = CommandType.Text)
        {
            var command = new SqlCommand(sql, connection)
            {
                CommandType = commandType,
                Transaction = transaction
            };

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

    }
}

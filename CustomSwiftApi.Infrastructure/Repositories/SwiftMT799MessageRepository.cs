using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Exeptions;
using CustomSwiftApi.Infrastructure.Models;
using Microsoft.Data.Sqlite;
using static CustomSwiftApi.Infrastructure.Constants.QueryConstants;
using static CustomSwiftApi.Infrastructure.ErrorMessages.ErrorMessage;

namespace CustomSwiftApi.Infrastructure.Repositories
{
    public class SwiftMT799MessageRepository : IRepository<SwiftMT799Message>
    {
        private readonly SqliteConnection _connection;

        public SwiftMT799MessageRepository(SqliteConnection connection)
        {
            _connection = connection;
            InitializeDatabaseAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Establish a link with the database, then input the information from the SwiftMT799Message entity into the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="InvalidInsertStatementExeption"></exception>
        public async Task<bool> InsertAsync(SwiftMT799Message entity)
        {
            await using (_connection)
            {
                try
                {
                    await _connection.OpenAsync();

                    string sqlQuery = InsertDataInSwiftMT799Messages;

                    await using (SqliteCommand command = new SqliteCommand(sqlQuery, _connection))
                    {
                        command.Parameters.AddWithValue("@BasicHeaderBlock", entity.BasicHeaderBlock);
                        command.Parameters.AddWithValue("@ApplicationHeaderBlock", entity.ApplicationHeaderBlock);
                        command.Parameters.AddWithValue("@TransactionReferenceNumber", entity.TransactionReferenceNumber);
                        command.Parameters.AddWithValue("@RelatedReference", entity.RelatedReference);
                        command.Parameters.AddWithValue("@Narrative", entity.Narrative);
                        command.Parameters.AddWithValue("@MAC", entity.MAC);
                        command.Parameters.AddWithValue("@CHK", entity.CHK);

                        int affectRows = await command.ExecuteNonQueryAsync();

                        return affectRows > 0;
                    }
                }
                catch (Exception)
                {
                    throw new InvalidInsertStatementExeption(InvalidInsertStatementErrorMessage);
                }
            }
        }

        /// <summary>
        /// Establish a link with the database, then create a table SwiftMT799Messages if not exist.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="InvalidInitializeDatabaseExeption"></exception>
        private async Task InitializeDatabaseAsync()
        {
            await using (_connection)
            {
                try
                {
                    await _connection.OpenAsync();

                    string sqlQuery = CreateTableSwiftMT799Messages;

                    await using (SqliteCommand command = new SqliteCommand(sqlQuery, _connection))
                    {
                        await command.ExecuteNonQueryAsync();
                    }

                }
                catch (Exception)
                {
                    throw new InvalidInitializeDatabaseExeption(InvalidInitializeDatabaseErrorMessage);
                }
            }
        }
    }
}

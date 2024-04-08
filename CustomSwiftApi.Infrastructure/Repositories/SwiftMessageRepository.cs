using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Models;
using Microsoft.Data.Sqlite;

namespace CustomSwiftApi.Infrastructure.Repositories
{
    public class SwiftMessageRepository : IRepository<SwiftMessage>
    {
        private readonly SqliteConnection _connection;

        public SwiftMessageRepository(SqliteConnection connection)
        {
            _connection = connection;
            InitializeDatabaseAsync().GetAwaiter().GetResult();
        }

        public async Task Insert(SwiftMessage entity)
        {
            throw new NotImplementedException();
        }

        private async Task InitializeDatabaseAsync()
        {
            using (_connection)
            {
                try
                {
                    await _connection.OpenAsync();

                    string sqlQuery = "";

                    using (SqliteCommand command = new SqliteCommand(sqlQuery, _connection))
                    {
                        await command.ExecuteNonQueryAsync();
                    }

                }
                catch (Exception)
                {

                }
            }
        }
    }
}

using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Models;
using Microsoft.Data.Sqlite;

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

        public async Task Insert(SwiftMT799Message entity)
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

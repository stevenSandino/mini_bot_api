using Microsoft.AspNetCore.Connections;
using mini_bot_api.Interface;
using Npgsql;
using System.Data;

namespace mini_bot_api.Dao
{
    public class Connection:IConnection
    {
        public Connection() { }

        public IDbConnection GetConnection()
        {
            NpgsqlConnection? connection = null;
            if (connection == null)
            {
                string connectionString = GetDbConnectionString();
                connection = new NpgsqlConnection(connectionString);
            }
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }
        private string GetDbConnectionString()
        {
            string DB_USERNAME = "postgres";
            string DB_PASSWORD = "admin";
            string DB_HOST = "localhost";
            string DB_PORT = "5432";
            string DB_NAME = "miniBotDB";

            return $"Host={DB_HOST};Port={DB_PORT};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_NAME};Timeout=300;CommandTimeout=300";
        }
    }
}

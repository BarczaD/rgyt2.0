using System;
using System.Collections.Generic;
using System.Text;

namespace rgyt2._0.Database
{
    using Microsoft.Data.Sqlite;

    public class SQLiteDbContext
    {
        private readonly string _connectionString;

        public SQLiteDbContext(string dbPath)
        {
            _connectionString = $"Data Source={dbPath}";
            Initialize();
        }

        public SqliteConnection CreateConnection()
        {
            return new SqliteConnection(_connectionString);
        }

        private void Initialize()
        {
            using var conn = CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = """
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    IsAdmin INTEGER NOT NULL DEFAULT 0,
                    IsActive INTEGER NOT NULL DEFAULT 1
                );
            """;

            cmd.ExecuteNonQuery();
        }
    }

}

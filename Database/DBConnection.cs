using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public abstract class DBConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DBConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("The connection string cannot be null or empty.");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}

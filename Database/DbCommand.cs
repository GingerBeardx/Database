using System;

namespace Database
{
    public class DbCommand
    {
        private DBConnection Connection { get; set; }
        private string DBCommand { get; set; }

        public DbCommand(DBConnection connection, string dbCommand)
        {
            if (connection == null)
                throw new InvalidOperationException("A connection must be passed.");

            if (string.IsNullOrWhiteSpace(dbCommand))
                throw new InvalidOperationException("The command cannot be null or empty.");

            Connection = connection;
            DBCommand = dbCommand;
        }

        public void Execute()
        {
            Connection.OpenConnection();

            Console.WriteLine(DBCommand);

            Connection.CloseConnection();
        }
    }
}

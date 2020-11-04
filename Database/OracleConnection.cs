using System;

namespace Database
{
    class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }


        public override void CloseConnection()
        {
            Console.WriteLine("Closed Oracle Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opened Oracle Connection");
        }
    }
}

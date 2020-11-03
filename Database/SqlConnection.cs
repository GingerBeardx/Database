using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Database
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }


        public override void CloseConnection()
        {
            Console.WriteLine("Closed SQL Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opened SQL Connection");
        }
    }
}

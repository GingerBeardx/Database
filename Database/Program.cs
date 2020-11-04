using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Database Simulator");
            Console.WriteLine();

            var connection = new OracleConnection("Connection to OracleDatabase");
            var command = new DbCommand(connection, "Insert a new record into the DB");
            command.Execute();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

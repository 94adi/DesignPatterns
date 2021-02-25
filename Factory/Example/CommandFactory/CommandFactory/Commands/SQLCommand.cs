using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory.Commands
{
    class SQLCommand : IDataSourceCommand
    {
        public readonly string _connectionString;
        public string ConnectionString { get => _connectionString; }

        public SQLCommand(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Execute()
        {
            Console.WriteLine("Connecting to database...");
            Console.WriteLine("Reading first 1000 rows from SQL DB");
        }
    }
}

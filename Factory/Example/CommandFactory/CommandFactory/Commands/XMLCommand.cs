using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory.Commands
{
    public class XMLCommand : IDataSourceCommand
    {
        public readonly string _connectionString;
        public string ConnectionString { get => _connectionString; }

        public XMLCommand(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Execute()
        {
            Console.WriteLine("Connecting to XML source...");
            Console.WriteLine("Reading first 1000 rows from XML source");
        }
    }
}

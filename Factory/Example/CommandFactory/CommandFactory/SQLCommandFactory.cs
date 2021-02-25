using CommandFactory.Commands;
using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory
{
    public class SQLCommandFactory : ICommandFactory
    {
        public ICommand Create()
        {
            Console.WriteLine("Instantiation SQL command...");
            Console.WriteLine("Enter connection string");
            var connectionString = Console.ReadLine();
            return new SQLCommand(connectionString);
        }
    }
}

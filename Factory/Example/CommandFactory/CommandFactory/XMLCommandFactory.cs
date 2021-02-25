using CommandFactory.Commands;
using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory
{
    public class XMLCommandFactory : ICommandFactory
    {
        public ICommand Create()
        {
            Console.WriteLine("Instantiation XML command...");
            Console.WriteLine("Enter source path");
            var connectionString = Console.ReadLine();
            return new XMLCommand(connectionString);
        }
    }
}

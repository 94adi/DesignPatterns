using System;
using System.Collections.Generic;

namespace CommandFactory
{

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CommandFactory();

            ICommand command = factory.CreateCommand();
            command.Execute();
        }
    }
}

using CommandFactory.Commands;
using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory
{
    public class PlayerHealthCommandFactory : ICommandFactory
    {
        public ICommand Create()
        {
            Console.WriteLine("Enter player and HP change...");
            return new PlayerHealthCommand(new Player() { Id = 1, Name = "Jonny", HealthPoints = 100 }, -10);
        }
    }
}

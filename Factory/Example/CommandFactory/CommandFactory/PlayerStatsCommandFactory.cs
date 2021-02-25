using CommandFactory.Commands;
using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory
{
    public class PlayerStatsCommandFactory : ICommandFactory
    {
        public ICommand Create()
        {
            Console.WriteLine("Enter player and HP change...");
            //done manually
            return new PlayerStatsCommand(new Player() { Id = 1, Name = "Jonny", HealthPoints = 100 });
        }
    }
}

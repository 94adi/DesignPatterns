using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory.Commands
{
    public class PlayerStatsCommand : IPlayerCommand
    {
        private readonly Player _player;
        public Player Player => _player;

        public PlayerStatsCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            Console.WriteLine("=================");
            Console.WriteLine($"Player Id: {Player.Id}");
            Console.WriteLine($"Player name: {Player.Name}");
            Console.WriteLine($"Player health points (HP): {Player.HealthPoints}");
            Console.WriteLine("=================");
        }
    }
}

using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory.Commands
{
    class PlayerHealthCommand : IPlayerCommand
    {
        private readonly Player _player;
        private int _healthChange;
        public PlayerHealthCommand(Player player, int change)
        {
            _player = player;
            _healthChange = change;
        }

        public Player Player => _player;

        public void Execute()
        {
            Console.WriteLine($"Updating player: {Player.Name}");
            if(_healthChange > 0)
                Console.WriteLine($"HP added: {_healthChange}");
            else
                Console.WriteLine($"HP subtracted: {_healthChange}");
            Player.HealthPoints += _healthChange;

            Console.WriteLine($"New HP: {Player.HealthPoints}");
        }
    }
}

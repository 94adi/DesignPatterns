using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public class EngineerPlayer : Player
    {
        private Player _player;
        private ToolBox _toolBox;

        public EngineerPlayer(Player player)
        {
            _player = player;
            _toolBox = new ToolBox();
        }


        public override void Attack()
        {
            _player.Attack();
        }

        public override void Run()
        {
            _player.Run();
        }

        public void Build()
        {
            Console.WriteLine("Building new bridge...");
            Console.WriteLine("Using...");
            foreach(var tool in _toolBox.Tools)
            {
                Console.WriteLine(tool);
            }
        }
    }
}

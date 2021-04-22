using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public class ScoutPlayer : Player
    {
        private Player _player;

        public ScoutPlayer(Player player)
        {
            _player = player;
        }

        public override void Attack()
        {
            _player.Attack();
        }

        public override void Run()
        {
            _player.Run();
            Console.WriteLine("Scout player running +20 speed!");
        }
    }
}

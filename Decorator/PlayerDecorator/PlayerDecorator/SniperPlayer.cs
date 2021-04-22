using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public class SniperPlayer : Player
    {
        private Player player;
        private Weapon sniper;

        public SniperPlayer(Player player)
        {
            this.player = player;
            sniper = new SniperWeapon();            
        }
        public override void Attack()
        {
            player.Attack();
            Console.WriteLine($"Extra sniper damage + {sniper.HitDamage}");
        }

        public override void Run()
        {
            player.Run();
        }
    }
}

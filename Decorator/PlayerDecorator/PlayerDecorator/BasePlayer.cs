using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public class BasePlayer : Player
    {
        public BasePlayer()
        {

        }

        public BasePlayer(string name)
        {
            Name = name;
        }
        public override void Attack()
        {
            Console.WriteLine("Basic player attack +10 damage");
        }

        public override void Run()
        {
            Console.WriteLine("Basic palyer running +10 speed");
        }
    }
}

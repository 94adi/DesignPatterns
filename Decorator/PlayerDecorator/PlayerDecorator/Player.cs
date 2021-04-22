using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; } = 100;
        public abstract void Run();
        public abstract void Attack();

        public void ShowHP()
        {
            Console.WriteLine($"HP:{HealthPoints}");
        }
    }
}

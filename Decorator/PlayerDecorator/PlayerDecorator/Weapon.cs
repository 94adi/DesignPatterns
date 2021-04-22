using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public  class Weapon
    {
        public string Name { get; private set; }
        public int HitDamage { get; private set; }

        public Weapon(string name, int damage)
        {
            Name = name;
            HitDamage = damage;
        }
    }
}

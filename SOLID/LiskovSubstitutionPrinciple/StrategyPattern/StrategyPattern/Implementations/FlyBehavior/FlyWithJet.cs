using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations
{
    class NoFlying : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Can't fly!");
        }
    }
}

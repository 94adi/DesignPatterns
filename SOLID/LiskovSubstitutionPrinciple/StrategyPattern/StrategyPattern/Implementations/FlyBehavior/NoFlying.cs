using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations
{
    class FlyWithJet : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Flying with jet propulsors");
        }
    }
}

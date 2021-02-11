using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations
{
    class FlyWithWingsTypeOne : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Flying with wings. Type one");
        }
    }
}

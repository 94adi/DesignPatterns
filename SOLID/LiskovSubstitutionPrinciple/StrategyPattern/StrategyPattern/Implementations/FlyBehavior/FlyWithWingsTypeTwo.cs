using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations
{
    class FlyWithWingsTypeTwo : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Flying with wings. Type two");
        }
    }
}

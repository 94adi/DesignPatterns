using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations.QuackBehavior
{
    class QuackLikeRobotTwo : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("Quacking like a robot. v2");
        }
    }
}

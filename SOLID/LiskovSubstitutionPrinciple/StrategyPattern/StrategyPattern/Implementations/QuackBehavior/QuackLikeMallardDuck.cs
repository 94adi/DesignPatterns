using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations.QuackBehavior
{
    class QuackLikeMallardDuck : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("Quacking like a mallard duck");
        }
    }
}

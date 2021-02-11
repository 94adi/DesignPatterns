using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations.QuackBehavior
{
    class QuackLikeRubberDuck : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("Quacking like a rubber duck");
        }
    }
}

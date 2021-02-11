using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Implementations.QuackBehavior
{
    class NoQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("No quacking sound");
        }
    }
}

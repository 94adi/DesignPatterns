using StrategyPattern.Implementations;
using StrategyPattern.Implementations.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            this._fly = new FlyWithWingsTypeOne();
            this._quack = new QuackLikeMallardDuck();
        }

        public override void Display()
        {
            Console.WriteLine("Display Mallard Duck");
        }
    }
}

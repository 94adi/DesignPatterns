using StrategyPattern.Implementations;
using StrategyPattern.Implementations.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Ducks
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            this._fly = new NoFlying();
            this._quack = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Display Wooden Duck");
        }
    }
}

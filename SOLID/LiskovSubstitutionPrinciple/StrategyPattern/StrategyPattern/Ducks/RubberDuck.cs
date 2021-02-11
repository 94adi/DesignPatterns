using StrategyPattern.Implementations;
using StrategyPattern.Implementations.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this._fly = new NoFlying();
            this._quack = new QuackLikeRubberDuck();
        }

        public override void Display()
        {
            Console.WriteLine("Display Rubber Duck");
        }
    }
}

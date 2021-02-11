using StrategyPattern.Implementations;
using StrategyPattern.Implementations.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Ducks
{
    public class RoboDuck : Duck
    {
        public RoboDuck()
        {
            this._fly = new FlyWithJet();
            this._quack = new QuackLikeRobotOne();
        }

        public override void Display()
        {
            Console.WriteLine("Display Robo Duck");
        }

    }
}

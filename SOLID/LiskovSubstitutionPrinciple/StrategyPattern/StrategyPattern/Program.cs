using StrategyPattern.Ducks;
using StrategyPattern.Implementations;
using StrategyPattern.Implementations.QuackBehavior;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck myDuck = new MallardDuck();
            myDuck.Display();
            myDuck.PerformFly();
            myDuck.PerformQuack();
            myDuck.SetFlyBehavior(new FlyWithWingsTypeTwo());
            myDuck.SetQuackBehavior(new NoQuack());
            myDuck.PerformFly();
            myDuck.PerformQuack();

            myDuck = new RubberDuck();
            myDuck.Display();
            myDuck.PerformFly();
            myDuck.PerformQuack();
            myDuck.SetFlyBehavior(new FlyWithJet());
            myDuck.SetQuackBehavior(new QuackLikeMallardDuck());
            myDuck.PerformFly();
            myDuck.PerformQuack();
        }
    }
}

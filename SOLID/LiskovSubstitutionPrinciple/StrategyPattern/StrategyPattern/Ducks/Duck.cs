using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {

        protected IFlyBehavior _fly;
        protected IQuackBehavior _quack;
        public string Name { get; set; }
        public string Color { get; set; }
        public void PerformFly()
        {
            _fly.PerformFly();
        }

        public void PerformQuack()
        {
            _quack.PerformQuack();
        }

        public void SetFlyBehavior(IFlyBehavior fly)
        {
            _fly = fly;
        }

        public void SetQuackBehavior(IQuackBehavior quack)
        {
            _quack = quack;
        }

        public Duck()
        {

        }

        public virtual void Display()
        {
            Console.WriteLine("Display generic duck");
        }

    }
}

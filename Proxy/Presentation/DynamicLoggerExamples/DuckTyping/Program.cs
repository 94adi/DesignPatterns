using System;

namespace DuckTyping
{
    class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Duck quacks");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swims");
        }
    }

    class MallardDuck
    {
        public void Quack()
        {
            Console.WriteLine("MallardDuck quacks");
        }

        public void Swim()
        {
            Console.WriteLine("MallardDuck swims");
        }
        
        public void Fly()
        {
            Console.WriteLine("MallardDuck flies");
        }
    }

    class Program
    {
        static void CallADuck(dynamic myDuck)
        {
            myDuck.Quack();
            myDuck.Swim();
        }

        static void Main(string[] args)
        {
            CallADuck(new Duck());
            CallADuck(new MallardDuck());
        }
    }
}

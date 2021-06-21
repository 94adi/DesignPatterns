using System;

namespace DynamicLoggerExamples
{
    class Pet
    {
        public string Name { get; set; }
        public float Speed { get; set; }

        public void DisplayPetStats()
        {
            Console.WriteLine($"Pet name: {Name} | Speed: {Speed}");
        }
        public override string ToString()
        {
            return $"Pet name: {Name} | Speed: {Speed}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ObjectExample();
            Console.WriteLine();
            DynamicVarExample();


        }

        static void DynamicVarExample()
        {
            Console.WriteLine("****** Dynamic var example START ******");
            dynamic dynamicVar = 10;
            Console.WriteLine($"dynamicVar value: {dynamicVar} | dynamicVar type: {dynamicVar.GetType()}");
            dynamicVar = "Hello World";
            Console.WriteLine($"dynamicVar value: {dynamicVar} | dynamicVar type: {dynamicVar.GetType()}");
            dynamicVar = new Pet();
            dynamicVar.Name = "Ralph";
            dynamicVar.Speed = 53.94f;
            //late binding
            dynamicVar.DisplayPetStats();
            //dynamicVar.Gersshshdhd(253252, "5353");
            Console.WriteLine($"dynamicVar value: {dynamicVar} | dynamicVar type: {dynamicVar.GetType()}");

            Console.WriteLine("****** Dynamic var example END ******");
        }

        static void ObjectExample()
        {
            Console.WriteLine("****** Object var example START ******");
            object objectVar = 10;
            Console.WriteLine($"dynamicVar value: {objectVar} | dynamicVar type: {objectVar.GetType()}");
            objectVar = "Hello World";
            Console.WriteLine($"dynamicVar value: {objectVar} | dynamicVar type: {objectVar.GetType()}");
            objectVar = new Pet();
            ((Pet)objectVar).Name = "Ralph";
            ((Pet)objectVar).Speed = 53.94f;
            ((Pet)objectVar).DisplayPetStats();
            Console.WriteLine($"dynamicVar value: {objectVar} | dynamicVar type: {objectVar.GetType()}");

            Console.WriteLine("****** Object var example END ******");
        }
    }
}

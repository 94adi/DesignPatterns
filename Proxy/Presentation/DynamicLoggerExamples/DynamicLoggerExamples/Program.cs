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
    }
    class Program
    {
        static void Main(string[] args)
        {

            dynamic dynamicVar = 10;
            dynamicVar = "Hello World";
            dynamicVar = new Pet();
            dynamicVar.Name = "Ralph";
            dynamicVar.Speed = 53.94f;
            dynamicVar.DisplayPetStats();

        }
    }
}

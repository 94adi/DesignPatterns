using System;
using SimpleSerialize.Entities;
using SimpleSerialize.SerializeService;

namespace SimpleSerialize
{

    class Program
    {               
        static void Main(string[] args)
        {
            JamesBondCar jbc = new JamesBondCar();
            ISerialize serializer;

            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            jbc.theRadio.hasTweeters = true;

            Console.WriteLine("Serialize to: ");
            Console.WriteLine("1. JSON");
            Console.WriteLine("2. XML");

            int input = 0;
            bool parsingResult = false;

            while (!parsingResult)
            {
                parsingResult = Int32.TryParse(Console.ReadLine(),out input);
            }
     

            switch (input)
            {
                
                case 1: serializer = new JsonSerializer(); break;
                case 2: serializer = new XMLSerializer<JamesBondCar>(); break;
                default: serializer = new JsonSerializer(); break;
            }

            string result = serializer.Serialize(jbc);
            Console.WriteLine("Result:");
            Console.WriteLine(result);

            Console.ReadLine();
        }   
    }
}
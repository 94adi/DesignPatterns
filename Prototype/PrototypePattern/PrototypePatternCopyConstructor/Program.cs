using System;
using static System.Console;

namespace PrototypePatternCopyConstructor
{
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Address(Address other)
        {
            StreetName = other.StreetName;
            HouseNumber = other.HouseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }

    public class Person 
    {
        public  string[] Names;
        public readonly Address Address;
        public int Age;

        public Person(string[] names, Address address, int age)
        {
            Names = names;
            Address = address;
            Age = age;
        }

        public Person(Person other)
        {
            Names = other.Names ;
            Address = new Address(other.Address);
            Age = other.Age;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Age)}: {Age}, {nameof(Address)}: {Address}";
        }

    }

    public static class Demo
    {
        static void Main()
        {
            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123), 12);

            var jane = new Person(john);
            jane.Address.HouseNumber = 321;
            jane.Address.StreetName = "New address";
            jane.Names = new[] { "Jane", "Smith" };
            jane.Age = 18;

            WriteLine(john);
            WriteLine(jane);
        }
    }
}

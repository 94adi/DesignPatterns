using System;

namespace FacadeGenericExample
{
    class Client
    {
        private readonly Facade _facade;

        public Client()
        {
            _facade = new Facade(new Subsystem1(), new Subsystem2());
        }
        public void ComplexOperation()
        {
            Console.Write(_facade.Operation());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ComplexOperation();
        }
    }
}

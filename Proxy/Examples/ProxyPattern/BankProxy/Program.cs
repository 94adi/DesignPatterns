using System;

namespace BankProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pin: ");
            int pin = int.Parse(Console.ReadLine());

            CartBank cartbank = new CartBank();
            cartbank.getPIN(pin);

            Console.WriteLine($"Your current balance: {cartbank.CheckStateAccount()}");
            Console.WriteLine("Withdraw 4,000 USD from the bank");
            cartbank.PayOutMoneyFromAccount(4000);
            Console.WriteLine("You have: " + cartbank.CheckStateAccount() + " USD left in your account");

            Console.ReadKey();
        }
    }
}

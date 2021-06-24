using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using ImpromptuInterface;

namespace DynamicLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount bankAccount = DynamicLogger<BankAccount>.As<IBankAccount>();

            bankAccount.Deposit(100);
            bankAccount.Withdraw(50);

            Console.WriteLine(bankAccount);

        }
    }
}

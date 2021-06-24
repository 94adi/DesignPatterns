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

            bankAccount.Name = "John Smith";

            bankAccount.Deposit(1000);
            bankAccount.Withdraw(50);
            bankAccount.Withdraw(50);
            bankAccount.Withdraw(35);
            bankAccount.Deposit(250);
            bankAccount.Withdraw(20);
            bankAccount.Deposit(3);
            bankAccount.Withdraw(100);
            bankAccount.Withdraw(5);
            bankAccount.Withdraw(50);
            bankAccount.Deposit(100);
            bankAccount.Withdraw(50);
            bankAccount.Deposit(5);
            var createdDate = bankAccount.DateCreated;
            
            Console.WriteLine("***** Calling ToString() on proxy object *****");
            Console.WriteLine(bankAccount);

            Console.ReadLine();

        }
    }
}

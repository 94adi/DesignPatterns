using System;

namespace StatePattern.Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(() => Console.WriteLine("Account unfrozen"));
            acc.HolderVerified();
            acc.Deposit(100);
            Console.WriteLine(acc.Balance);
            acc.Withdraw(50);
            Console.WriteLine(acc.Balance);
            acc.Freeze();
            acc.Deposit(12);
            Console.WriteLine(acc.Balance);
            acc.Close();
            acc.Deposit(4);
            acc.Withdraw(10);
            Console.WriteLine(acc.Balance);

        }
    }
}

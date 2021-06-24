using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLogger
{
    public class BankAccount : IBankAccount
    {
        private int _balance;
        private const int OVERDRAFTLIMIT = -500;

        private DateTime _dateCreated;

        public DateTime DateCreated
        {
            get
            {
                return _dateCreated;
            }
        }

        public string Name { get ; set; }

        public BankAccount()
        {
            _dateCreated = DateTime.Now;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance is now {_balance}");
        }

        public bool Withdraw(int amount)
        {
            if (_balance - amount >= OVERDRAFTLIMIT)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance is now {_balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(_balance)}: {_balance}";
        }
    }
}

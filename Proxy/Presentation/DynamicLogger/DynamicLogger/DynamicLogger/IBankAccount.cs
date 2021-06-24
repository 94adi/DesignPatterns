using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLogger
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
    }
}

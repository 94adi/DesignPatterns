using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProxy
{
    class BankAccount : IPayment
    {
        private double _balance = 10000;

        public double CheckStateAccount()
        {
            return _balance;
        }

        public void PayOutMoneyFromAccount(double AmountPayedOutMoney)
        {
            _balance = _balance - AmountPayedOutMoney;
        }
    }
}

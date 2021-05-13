using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProxy
{
    class CartBank : IPayment
    {
        IPayment BankAccount;
        private int PIN;
        private bool _isPinValid;

        public bool IsPinValid { get; private set; }

        public CartBank()
        {
            _isPinValid = false;
        }

        public void getPIN(int pin)
        {
            PIN = pin;
            CheckPinIsValid();
        }

        private void CheckPinIsValid()
        {
            if (PIN == 1223)
            {
                OpenAccessToAccount();
                _isPinValid = true;
            }
            else
            {
                _isPinValid = false;
            }
        }

        private void OpenAccessToAccount()
        {
            PaymentFactory paymentfactory = new BankAccountFactory();

            BankAccount = paymentfactory.Bank();
        }

        public double CheckStateAccount()
        {
            if (_isPinValid)
            {
                return BankAccount.CheckStateAccount();
            }

            Console.WriteLine("Access denied!");
            return double.NaN;
        }

        public void PayOutMoneyFromAccount(double AmountPayedOutMoney)
        {
            if (_isPinValid)
            {
                BankAccount.PayOutMoneyFromAccount(AmountPayedOutMoney);
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}

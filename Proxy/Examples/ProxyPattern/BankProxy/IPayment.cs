using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProxy
{
    public interface IPayment
    {
        double CheckStateAccount();
        void PayOutMoneyFromAccount(double AmountPayedOutMoney);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProxy
{
    class BankAccountFactory : PaymentFactory
    {
        public override IPayment Bank()
        {
            return new BankAccount();
        }
    }
}

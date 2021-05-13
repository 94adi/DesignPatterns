using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProxy
{
    abstract class PaymentFactory
    {
        public abstract IPayment Bank();
    }
}

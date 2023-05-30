using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;
        public PaymentContext()
        {

        }
        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void PerformPayment(double amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Builder
{
    public class CreditPaymentBuilder : IPaymentBuilder
    {
        private IPayment _payment = new CreditPayment();

        public void BuildPaymentMethod()
        {
            Console.WriteLine("Building credit payment method...");
        }

        public void BuildPaymentAmount()
        {
            Console.WriteLine("Building credit payment amount...");
        }

        public IPayment GetResult()
        {
            return _payment;
        }
    }
}

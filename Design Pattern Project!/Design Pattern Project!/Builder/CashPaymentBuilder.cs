using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Builder
{
    public class CashPaymentBuilder : IPaymentBuilder
    {
        private IPayment _payment = new CashPayment();

        public void BuildPaymentMethod()
        {
            MessageBox.Show("Building cash payment method...");
        }

        public void BuildPaymentAmount()
        {
            MessageBox.Show("Building cash payment amount...");
        }

        public IPayment GetResult()
        {
            return _payment;
        }
    }
}

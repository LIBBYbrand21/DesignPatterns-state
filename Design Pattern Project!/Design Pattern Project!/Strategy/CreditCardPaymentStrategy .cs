using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Strategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private Form1 form;
        public CreditCardPaymentStrategy(Form1 form)
        {
            this.form = form;
        }
        public void Pay(double amount)
        {
            form.payLabel.Visible = true;
            form.payLabel.Text = "העבר/הנח כרטיס";
            Task.Delay(1000).Wait();
            form.payLabel.Visible = false;
            MessageBox.Show("התשלום עבר בהצלחה!,תודה");
        }
    }
}

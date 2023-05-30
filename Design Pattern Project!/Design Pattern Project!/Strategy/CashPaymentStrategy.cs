using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Strategy
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        private Form1 form;
        public CashPaymentStrategy(Form1 form)
        {
            this.form = form;
        }
        public void Pay(double amount)
        {
            if (double.Parse(form.cashtextBox.Text) == amount)
            {
                form.payLabel.Visible = false;
                form.cashtextBox.Visible = false;
                form.submitButton.Visible = false;
                Task.Delay(1000).Wait();
                form.payLabel.Visible = false;
                MessageBox.Show("התשלום עבר בהצלחה!,תודה");
            }
            else
            {
                if (double.Parse(form.cashtextBox.Text) > amount)
                {
                    form.payLabel.Visible = true;
                    form.payLabel.Text = $"עודף-{double.Parse(form.cashtextBox.Text) - amount:c2}";
                    form.cashtextBox.Visible = false;
                    form.submitButton.Visible = false;
                    Task.Delay(1000).Wait();
                    form.payLabel.Visible = false;
                    MessageBox.Show("התשלום עבר בהצלחה!,תודה");
                }
                else
                {
                    form.cashtextBox.Text = String.Empty;
                    form.payLabel.Text = $" הכנס את הסכום המתאים ";
                }
            }
        }
    }
}

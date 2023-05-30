using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Strategy
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
/*        public static bool isPaySuccess;
*/
        private Form1 form;
        public CashPaymentStrategy(Form1 form)
        {
            this.form = form;
        }
        public void Pay(double amount)
        {
            //הבדיקה שצריך לבצע כאן היא האם הקלט הוא אכן מספר
            if (form.cashtextBox.Text == "")
            {
                form.cashtextBox.Text = "0";
            }
            if (double.Parse(form.cashtextBox.Text) == amount)
            {
                form.payLabel.Visible = false;
                form.cashtextBox.Visible = false;
                form.submitButton.Visible = false;
                Task.Delay(1000).Wait();
                form.payLabel.Visible = false;
                MessageBox.Show("התשלום עבר בהצלחה!,תודה");
                IPaymentStrategy.isPaySuccess = true;
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
                    IPaymentStrategy.isPaySuccess = true;
                }
                else
                {
                    form.cashtextBox.Text = String.Empty;
                    form.payLabel.Text = $" הכנס את הסכום המתאים ";
                    IPaymentStrategy.isPaySuccess = false;
                }
            }
        }
    }
}

using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.State
{
    public class CompleteState : MenuState
    {
        private Form1 form;
        public CompleteState(Form1 form)
        {
            this.form = form;
        }
        public override string display()
        {
            form.paymentButton.Enabled = false;
            form.cashtextBox.Text = string.Empty;
            form.cashtextBox.Visible = false;
            form.submitButton.Visible = false;
            form.itemsLabel.Visible = false;
            form.toPayLabel.Text = String.Empty;
            form.itemsLabel.Text = $"רשימת המוצרים-";
            form.payment.Enabled = false;
            form.startButton.Enabled = true;

            return "Order Completion Displayed";
        }

        public override string endOrder()
        {
            return "Order Completed";
        }

        public override string processPayment()
        {
            return "Payment Not Applicable";
        }

        public override string selectItem()
        {
            return "Item Selection Not Applicable";
        }
    }
}


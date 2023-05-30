using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.State
{
    public class PaymentState : MenuState
    {
        private Form1 form;
        public PaymentState(Form1 form)
        {
            this.form = form;
        }
        public override string display()
        {
            form.paymentButton.Enabled = false;
            form.comboBoxSnack.Enabled = false;
            form.comboBoxPastris.Enabled = false;
            form.comboBoxDrink.Enabled = false;
            form.comboBoxCupDrink.Enabled = false;
            form.giftButton.Enabled = true;
            form.bagButton.Enabled = true;
            form.noPackageButton.Enabled = true;

            return "Payment Options Displayed";
        }
        public override string endOrder()
        { 
            return "Order Completion State Entered";
        }
        public override string processPayment()
        {
            form.cardButton.Enabled = true;
            form.cashButton.Enabled = true;

            return "Payment Processed";
        }

        public override string selectItem()
        {
            return "Item Selection Not Applicable";
        }
    }
}

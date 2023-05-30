using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project_.State
{

    public class ItemDetailesState : MenuState
    {
        private Form1 form;
        public ItemDetailesState(Form1 form)
        {
            this.form = form;
        }
        public override string display()
        {
            form.paymentButton.Enabled = false;
            form.comboBoxDrink.Text = String.Empty;
            form.comboBoxCupDrink.Text = String.Empty;
            form.comboBoxPastris.Text = String.Empty;
            form.comboBoxSnack.Text = String.Empty;
            form.Snack.Enabled = false;
            form.Drink.Enabled = false;
            form.Pastris.Enabled = false;
            form.CupDrink.Enabled = false;

            return "Item Selection Displayed";
        }
        public override string endOrder()
        {
            return "Order Not Applicable";
        }
        public override string processPayment()
        {
            return "Payment Processing State Entered";
        }
        public override string selectItem()
        { 
            return "Item Selected";
        }
    }
}

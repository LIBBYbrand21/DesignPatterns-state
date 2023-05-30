using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project_.State
{
    public class HomePageState : MenuState
    {
        private Form1 form;
        public HomePageState(Form1 form)
        {
            this.form = form;
        }
        public override string display()
        {
            form.startButton.Enabled = false;
            form.Snack.Enabled = true;
            form.Drink.Enabled = true;
            form.Pastris.Enabled = true;
            form.CupDrink.Enabled = true;

            return "Main Menu Displayed";
        }
        public override string selectItem()
        {
            return "Item Selection State Entered";
        }
        public override string processPayment()
        {
            return "Payment Not Applicable";
        }
        public override string endOrder()
        {
            return "Order Not Applicable";
        }
    }
}

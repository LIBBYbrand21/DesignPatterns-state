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
        private Machine machine;
        public PaymentState(Form1 form)
        {
            this.form = form;
        }
        public override void display()
        {
            form.comboBoxSnack.Enabled = false;
            form.comboBoxPastris.Enabled = false;
            form.comboBoxDrink.Enabled = false;
            form.comboBoxCupDrink.Enabled=false;
            form.giftButton.Enabled = true;
            form.bagButton.Enabled = true;
            Console.WriteLine("ConcreteState Item Detailes display items");
        }
        public override void endOrder()
        {
            MenuState state = new CompleteState(form);
            machine.TransitionTo(state);
            Console.WriteLine("ConcreteState Item Detailes display items");
        }
        public override void processPayment()
        {
            form.cardButton.Enabled = true;
            form.cashButton.Enabled = true;
            Console.WriteLine("ConcreteState Item Detailes display items");
        }

        public override void selectItem()
        {
            Console.WriteLine("ConcreteState Item Detailes display items");
        }
    }
}

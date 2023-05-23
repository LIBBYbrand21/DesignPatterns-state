using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project_.State
{
    class ItemDetailesState : MenuState
    {
        private Form1 form;
        public ItemDetailesState(Form1 form)
        {
            this.form = form;
        }
        public override void display()
        {
            form.Snack.Enabled = false;
            form.Drink.Enabled = false;
            form.Pastris.Enabled = false;
            form.CupDrink.Enabled = false;

            Console.WriteLine("ConcreteState Item Detailes display items");

        }
        public override void endOrder()
        {
            Console.WriteLine("ConcreteState Item Detailes,can't  end the order");
        }

        public override void processPayment()
        {
            Console.WriteLine("ConcreteState Item Detailes,can't  pay");
        }
        public override void selectItem()
        {
            form.TransitionTo(new PaymentState());
            Console.WriteLine("ConcreteState Item Detailes select Item");
        }
    }
}

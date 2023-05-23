using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.State
{
    internal class PaymentState : MenuState
    {
        private Form1 form;
        public PaymentState(Form1 form)
        {
            this.form = form;
        }
        public override void display()
        {
            Console.WriteLine("ConcreteState Item Detailes display items");
        }
        public override void endOrder()
        {
            Console.WriteLine("ConcreteState Item Detailes display items");
        }
        public override void processPayment()
        {
            Console.WriteLine("ConcreteState Item Detailes display items");
        }

        public override void selectItem()
        {
            Console.WriteLine("ConcreteState Item Detailes display items");
        }
    }
}

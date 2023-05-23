using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project_.State
{
    class HomePageState : MenuState
    {

        private Form1 form;
        

        public HomePageState(Form1 form)
        {
            this.form = form;
        }
        public override void display()
        {
            form.startButton.Enabled = false;
            form.Snack.Enabled = true;
            form.Drink.Enabled = true;
            form.Pastris.Enabled=true;
            form.CupDrink.Enabled = true;
            form.TransitionTo(new ItemDetailesState());
            Console.WriteLine("ConcreteState home page display");
        }

        public override void selectItem()
        {
            Console.WriteLine("ConcreteState home page,can't  select items ");
        }

        public override void processPayment()
        {
            Console.WriteLine("ConcreteState home page,can't  pay");

        }

        public override void endOrder()
        {
            Console.WriteLine("ConcreteState home page,can't  end the order");

        }


    }
}

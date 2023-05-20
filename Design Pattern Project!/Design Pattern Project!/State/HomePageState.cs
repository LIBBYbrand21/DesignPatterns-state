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
        /*public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this._context.TransitionTo(new ItemDetailesState());
        }

        public override void Handle1(MachineMenu mech)
        {
            throw new NotImplementedException();
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
        }

        public override void Handle2(MachineMenu mech)
        {
            throw new NotImplementedException();
        }
    }*/
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
            form.comboBoxSnack.Enabled = true;  
            form.comboBoxPastris.Enabled = true;
            form.comboBoxDrink.Enabled = true;
            form.comboBoxCupDrink.Enabled=true;
            

            //throw new NotImplementedException();
        }

        public override void processPayment()
        {
            throw new NotImplementedException();
        }

        public override void selectItem()
        {
            throw new NotImplementedException();
        }

        
    }
}

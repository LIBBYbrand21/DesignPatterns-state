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
        /*   public override void Handle1(MachineMenu mech)
           {
               Console.Write("ConcreteStateB handles request1.");
           }



           public override void Handle2(MachineMenu mech)
           {
               Console.WriteLine("ConcreteStateB handles request2.");
               Console.WriteLine("ConcreteStateB wants to change the state of the context.");
               this._context.TransitionTo(new HomePageState());
           }*/
        public override void display()
        {
            form.Snack.Enabled = false;
            form.Drink.Enabled = false;
            form.Pastris.Enabled = false;
            form.CupDrink.Enabled = false;
            /*form.comboBoxSnack.Enabled = true;
            form.comboBoxPastris.Enabled = true;
            form.comboBoxDrink.Enabled = true;
            form.comboBoxCupDrink.Enabled = true;*/
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

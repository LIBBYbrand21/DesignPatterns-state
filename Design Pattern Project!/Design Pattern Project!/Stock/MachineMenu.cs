using Design_Pattern_Project_.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Stock
{
    public class MachineMenu
    {
        /*private MenuState currentState;
        public MachineMenu()
        {
            currentState = new HomePageState(Form1 form);
        }*/
        public void Display()
        {
           // currentState.display();
        }
        public void SelectItem()
        {
            //currentState.selectItem();
        }
        public void ProcessPayment()
        {
            //currentState.processPayment();
        }
        public void ChangeToItemDetailsState()
        {
           // currentState = new ItemDetailesState();
        }
        public void ChangeToPaymentState()
        {
            //currentState = new PaymentState();
        }
    }
}

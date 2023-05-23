using Design_Pattern_Project_.State;
using DesignPatternsProject.AbstractFactory.prop;
using DesignPatternsProject.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Stock
{
    public class Machine
    {
        private Form1 form;
        private MenuState currentState;

        public Machine(Form1 form)
        {
            this.form = form;   
            createComBox();
        }
        private void createComBox()
        {
            foreach (var itemEntry in Menu.inventoryDrink)
            {
                Item item = itemEntry.Key;
                string itemName = item.Name;
                double itemPrice = item.Price;
                string itemDetails = $"{itemName} - {itemPrice:C2}";
                form.comboBoxDrink.Items.Add(itemDetails);
                /*if (itemEntry.Value < 1)
                {
                }*/
            }
            foreach (var itemEntry in Menu.inventoryPastris)
            {
                Item item = itemEntry.Key;
                string itemName = item.Name;
                double itemPrice = item.Price;
                string itemDetails = $"{itemName} - {itemPrice:C2}";
                form.comboBoxPastris.Items.Add(itemDetails);
                /*if (itemEntry.Value < 1)
                {
                }*/
            }
            foreach (var itemEntry in Menu.inventoryCupDrink)
            {
                Item item = itemEntry.Key;
                string itemName = item.Name;
                double itemPrice = item.Price;
                string itemDetails = $"{itemName} - {itemPrice:C2}";
                form.comboBoxCupDrink.Items.Add(itemDetails);
                /*if (itemEntry.Value < 1)
                {
                }*/
            }
            foreach (var itemEntry in Menu.inventorySnack)
            {
                Item item = itemEntry.Key;
                string itemName = item.Name;
                double itemPrice = item.Price;
                string itemDetails = $"{itemName} - {itemPrice:C2}";
                form.comboBoxSnack.Items.Add(itemDetails);
                /*if (itemEntry.Value < 1)
                {
                }*/
            }
        }
        public void TransitionTo(MenuState state)
        {
            currentState = state;
        }
        public void Display()
        {
            currentState.display();
        }
        public void SelectItem()
        {
            currentState.selectItem();
        }
        public void ProcessPayment()
        {
            currentState.processPayment();
        }
        public void ChangeToItemDetailsState()
        {
            currentState = new ItemDetailesState(form);
        }
        public void ChangeToPaymentState()
        {
            currentState = new PaymentState(form);
        }
    }
    /* Decorator
     Item item = new Item { Name = "Item", Price = 10.0, Description = "An item" };
     Item baggedItem = new BagDecorator(item);
     Item giftItem = new GiftDecorator(item);*//*

    //Builder
    public class PaymentDirector
    {
        public void Construct(IPaymentBuilder builder)
        {
            builder.BuildPaymentMethod();
            builder.BuildPaymentAmount();
        }
    }

    // Client code
    public class Client
    {
        public void Main()
        {
            var director = new PaymentDirector();
            var creditBuilder = new CreditPaymentBuilder();
            var cashBuilder = new CashPaymentBuilder();

            director.Construct(creditBuilder);
            var creditPayment = creditBuilder.GetResult();
            creditPayment.ProcessPayment();

            director.Construct(cashBuilder);
            var cashPayment = cashBuilder.GetResult();
            cashPayment.ProcessPayment();
        }
    }*/
}

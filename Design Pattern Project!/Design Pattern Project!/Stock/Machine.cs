using Design_Pattern_Project_.State;
using DesignPatternsProject.AbstractFactory.prop;
using DesignPatternsProject.Stock;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Pattern_Project_.Stock
{
    public class Machine
    {
        private Form1 form;
        private MenuState currentState;
        public ObjectItems objectSelectedItems = new ObjectItems();


        public Machine(Form1 form)
        {
            this.form = form;
            CreateComBox();
        }
        private void CreateComBox()
        {
            foreach (var itemEntry in Menu.inventoryDrink)
            {
                /* Item item = itemEntry.Key;
                 string itemName = item.Name;
                 double itemPrice = item.Price;
                 string itemDetails = $"{itemName} - {itemPrice:C2}";*/
                form.comboBoxDrink.Items.Add(itemEntry.Key);
                // form.comboBoxDrink.Items.Add(itemDetails);
                /*if (itemEntry.Value < 1)
                {
                }*/
            }
            foreach (var itemEntry in Menu.inventoryPastris)
            {
                /* Item item = itemEntry.Key;
                 string itemName = item.Name;
                 double itemPrice = item.Price;
                 string itemDetails = $"{itemName} - {itemPrice:C2}";*/
                form.comboBoxPastris.Items.Add(itemEntry.Key);
                /*if (itemEntry.Value < 1)
                {
                }*/
            }
            foreach (var itemEntry in Menu.inventoryCupDrink)
            {
                /*Item item = itemEntry.Key;
                string itemName = item.Name;
                double itemPrice = item.Price;
                string itemDetails = $"{itemName} - {itemPrice:C2}";*/
                form.comboBoxCupDrink.Items.Add(itemEntry.Key);
            }
            foreach (var itemEntry in Menu.inventorySnack)
            {
                form.comboBoxSnack.Items.Add(itemEntry.Key);
            }
        }
        public void SelectedText(string selectedItem, Dictionary<Item, int> inventory)
        {
            foreach (var itemEntry in /*items.inventorySnack*/inventory)
            {
                Item item = itemEntry.Key;

                if (selectedItem == item.ToString())
                {
                    if (itemEntry.Value < 0)
                    {
                        MessageBox.Show("אין מספיק במלאי, הנך מוחזר לתפריט הקודם");
                        // comboBox הוא trueכאן צריך לוודא איזה 
                        //והוא עדיין נותן להם לפעול????????????
                        form.comboBoxSnack.Enabled = false;
                        form.comboBoxCupDrink.Enabled = false;
                        form.comboBoxPastris.Enabled = false;
                        form.comboBoxDrink.Enabled = false;
                        form.homePageState.display();
                        break;
                    }
                    else
                    {
                        if (!form.itemsLabel.Visible)
                        {
                            form.itemsLabel.Visible = true;
                        }
                        // MessageBox.Show($"{itemEntry.Value}");
                        inventory[item] -= 1;
                        //  MessageBox.Show($"{inventory[item]}");
                        objectSelectedItems.Items.Add(itemEntry.Key);

                        objectSelectedItems.TotalPrice += itemEntry.Key.Price;
                        form.toPayLabel.Enabled = true;
                        form.toPayLabel.Text = $"{objectSelectedItems.TotalPrice:c2}";
                        form.itemsLabel.Text += "* " + item.Name.ToString();
                        form.homePageState.display();
                        form.comboBoxSnack.Enabled = false;
                        form.comboBoxCupDrink.Enabled = false;
                        form.comboBoxDrink.Enabled = false;
                        form.comboBoxPastris.Enabled = false;
                        form.paymentButton.Enabled = true;
                    }
                }
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


/*    //Builder
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

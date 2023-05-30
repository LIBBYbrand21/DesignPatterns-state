using Design_Pattern_Project_.State;
using Design_Pattern_Project_.Stock;
using Design_Pattern_Project_.Strategy;
using DesignPatternsProject.AbstractFactory.prop;
using DesignPatternsProject.Decorator;
using DesignPatternsProject.Stock;

namespace Design_Pattern_Project_
{
    public partial class Form1 : Form
    {
        public HomePageState homePageState;
        private ItemDetailesState itemDetails;
        private PaymentState paymentState;
        private string choosenPackage;
        PaymentContext paymentContext;

        Machine machine;

        public Form1()
        {
            InitializeComponent();
            homePageState = new HomePageState(this);
            itemDetails = new ItemDetailesState(this);
            paymentState = new PaymentState(this);
            machine = new Machine(this);
            paymentContext = new PaymentContext();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            homePageState.display();
            machine.currentState.display();
        }
        private void CupDrink_Click(object sender, EventArgs e)
        {
            comboBoxCupDrink.Enabled = true;
            /*machine.TransitionTo(itemDetails);
            machine.currentState.display();*/
            itemDetails.display();
        }
        private void Pastris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("אינו זמין כרגע");
            // machine.TransitionTo(itemDetails);
            // machine.currentState.display();
            //comboBoxPastris.Enabled = true;
            homePageState.display();
        }
        private void Drink_Click(object sender, EventArgs e)
        {
            comboBoxDrink.Enabled = true;
            /* machine.TransitionTo(itemDetails);
             machine.currentState.display();*/
            itemDetails.display();
        }
        private void Snack_Click(object sender, EventArgs e)
        {
            comboBoxSnack.Enabled = true;
            /*machine.TransitionTo(itemDetails);
            machine.currentState.display();*/
            itemDetails.display();
        }
        private void paymentButton_Click(object sender, EventArgs e)
        {
            //machine.TransitionTo(paymentState);
            //machine.currentState.display();
            itemDetails.display();
            paymentState.display();
        }
        private void comboBoxPastris_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxPastris.Items[comboBoxPastris.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelecteItem(selectedItem, Menu.inventoryPastris);
        }
        private void comboBoxSnack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxSnack.Items[comboBoxSnack.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelecteItem(selectedItem, Menu.inventorySnack);
        }
        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxDrink.Items[comboBoxDrink.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelecteItem(selectedItem, Menu.inventoryDrink);
        }
        private void giftButton_CheckedChanged(object sender, EventArgs e)
        {
            choosenPackage = giftButton.Checked.ToString();
            GiftDecorator giftDecorator = new GiftDecorator(machine.objectSelectedItems);
            toPayLabel.Text = $"{machine.objectSelectedItems.TotalPrice:c2}";
            paymentState.processPayment();
            giftButton.Enabled = false;
            bagButton.Enabled = false;
            noPackageButton.Enabled = false;
        }
        private void bagButton_CheckedChanged(object sender, EventArgs e)
        {
            choosenPackage = bagButton.Checked.ToString();
            BagDecorator bagDecorator = new BagDecorator(machine.objectSelectedItems);
            toPayLabel.Text = $"{machine.objectSelectedItems.TotalPrice:c2}";
            paymentState.processPayment();
            giftButton.Enabled = false;
            bagButton.Enabled = false;
            noPackageButton.Enabled = false;
        }
        private void comboBoxCupDrink_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = comboBoxCupDrink.Items[comboBoxCupDrink.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelecteItem(selectedItem, Menu.inventoryCupDrink);
        }
        private void cardButton_CheckedChanged_1(object sender, EventArgs e)
        {
            cashButton.Enabled = false;
            cardButton.Enabled = false;
            paymentButton.Enabled = false;
            paymentContext.SetPaymentStrategy(new CreditCardPaymentStrategy(this));
            machine.Pay(paymentContext);
            machine.FinishOrder();
        }
        private void cashButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentContext.SetPaymentStrategy(new CashPaymentStrategy(this));
            payLabel.Visible = true;
            payLabel.Text = "הכנס כסף";
            cashtextBox.Visible = true;
            cashButton.Enabled = false;
            cardButton.Enabled = false;
            submitButton.Visible = true;
        }

        private void noPackageButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentState.processPayment();
            giftButton.Enabled = false;
            bagButton.Enabled = false;
            noPackageButton.Enabled = false;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            machine.Pay(paymentContext);
            if (IPaymentStrategy.isPaySuccess)
            {
                machine.FinishOrder();
            }
        }
    }
}
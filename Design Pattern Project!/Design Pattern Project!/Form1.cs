using Design_Pattern_Project_.Observer;
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
        PaymentContext paymentContext;
        Suppliers Supplier;

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
            machine.currentState.display();
            selasLabel.Text = machine.currentState.display();
            machine.currentState = new HomePageState(this);
        }
        private void CupDrink_Click(object sender, EventArgs e)
        {
            comboBoxCupDrink.Enabled = true;
            string nextState = machine.SelectItem();
            machine.UpdateState(nextState);
            machine.currentState.display();
        }
        private void Pastris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("אינו זמין כרגע");
            string nextState = machine.SelectItem();
            machine.UpdateState(nextState);
            homePageState.display();
        }
        private void Drink_Click(object sender, EventArgs e)
        {
            comboBoxDrink.Enabled = true;
            string nextState = machine.SelectItem();
            machine.UpdateState(nextState);
            machine.currentState.display();
        }
        private void Snack_Click(object sender, EventArgs e)
        {
            comboBoxSnack.Enabled = true;
            string nextState = machine.SelectItem();
            machine.UpdateState(nextState);
            machine.currentState.display();
        }
        private void paymentButton_Click(object sender, EventArgs e)
        {
            machine.currentState.display();
            string nextState = machine.ProcessPayment();
            machine.UpdateState(nextState);
            machine.currentState.display();
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
            GiftDecorator giftDecorator = new GiftDecorator(machine.objectSelectedItems);
            machine.Packaging();
        }
        private void bagButton_CheckedChanged(object sender, EventArgs e)
        {
            BagDecorator bagDecorator = new BagDecorator(machine.objectSelectedItems);
            machine.Packaging();
        }
        private void comboBoxCupDrink_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = comboBoxCupDrink.Items[comboBoxCupDrink.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelecteItem(selectedItem, Menu.inventoryCupDrink);
        }
        private void cardButton_CheckedChanged_1(object sender, EventArgs e)
        {
            machine.Paying();
            paymentContext.SetPaymentStrategy(new CreditCardPaymentStrategy(this));
            machine.Pay(paymentContext);
            machine.FinishingOrder();
        }
        private void cashButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentContext.SetPaymentStrategy(new CashPaymentStrategy(this));
            payLabel.Visible = true;
            payLabel.Text = "הכנס כסף";
            cashtextBox.Visible = true;
            submitButton.Visible = true;
            machine.Paying();

        }
        private void noPackageButton_CheckedChanged(object sender, EventArgs e)
        {
            machine.Packaging();

        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            machine.Pay(paymentContext);
            if (IPaymentStrategy.isPaySuccess)
            {
                machine.FinishingOrder();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var supplierA = new Suppliers("a");
            var supplierB = new Suppliers("b");
            var supplierC = new Suppliers("c");
            var supplierD = new Suppliers("d");
            var supplierH = new Suppliers("h");
            machine.Attach(supplierA);
            machine.Attach(supplierB);
            machine.Attach(supplierC);
            machine.Attach(supplierD);
            machine.Attach(supplierH);
        }
    }
}
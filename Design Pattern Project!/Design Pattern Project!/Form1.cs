using Design_Pattern_Project_.State;
using Design_Pattern_Project_.Stock;
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

        Machine machine;
        
        public Form1()
        {
            InitializeComponent();
            homePageState = new HomePageState(this);
            itemDetails = new ItemDetailesState(this);
            paymentState = new PaymentState(this);
            machine = new Machine(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void startButton_Click(object sender, EventArgs e)
        {
            homePageState.display();
        }
        private void CupDrink_Click(object sender, EventArgs e)
        {
            comboBoxCupDrink.Enabled = true;
            itemDetails.display();
        }
        private void Pastris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("אינו זמין כרגע");
            homePageState.display();
            /*comboBoxPastris.Enabled = true;
            itemDetails.display();*/
        }
        private void Drink_Click(object sender, EventArgs e)
        {
            comboBoxDrink.Enabled = true;
            itemDetails.display();
        }
        private void Snack_Click(object sender, EventArgs e)
        {
            comboBoxSnack.Enabled = true;
            itemDetails.display();
        }
        private void paymentButton_Click(object sender, EventArgs e)
        {
            paymentState.display();
           
        }
       

        private void comboBoxPastris_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxPastris.Items[comboBoxPastris.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelectedText(selectedItem, Menu.inventoryPastris);

        }
        private void comboBoxSnack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxSnack.Items[comboBoxSnack.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelectedText(selectedItem, Menu.inventorySnack);
        }



        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxDrink.Items[comboBoxDrink.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelectedText(selectedItem, Menu.inventoryDrink);
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
            machine.SelectedText(selectedItem, Menu.inventoryCupDrink);
        }

        private void  cardButton_CheckedChanged_1(object sender, EventArgs e)
        {
            payLabel.Visible = true;
            payLabel.Text = "העבר/הנח כרטיס";
            cashButton.Enabled = false;
            cardButton.Enabled = false;
            paymentButton.Enabled=false;
            Task task = machine.EndOfPayment();
            
        }
        private void cashButton_CheckedChanged(object sender, EventArgs e)
        {
            payLabel.Visible = true;
            payLabel.Text = "הכנס כסף";
            cashtextBox.Visible=true;
            cashButton.Enabled = false;
            cardButton.Enabled = false;
           

        }

        private void noPackageButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentState.processPayment();
            giftButton.Enabled = false;
            bagButton.Enabled = false;
            noPackageButton.Enabled = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            machine.CashPayment();

        }
    }
}
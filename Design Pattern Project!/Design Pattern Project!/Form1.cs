using Design_Pattern_Project_.State;
using Design_Pattern_Project_.Stock;
using DesignPatternsProject.Stock;

namespace Design_Pattern_Project_
{
    public partial class Form1 : Form
    {
        public HomePageState homePageState;
        private ItemDetailesState itemDetails;
        Machine machine;
        public Form1()
        {
            InitializeComponent();
            homePageState = new HomePageState(this);
            itemDetails = new ItemDetailesState(this);
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
            comboBoxPastris.Enabled = true;
            itemDetails.display();
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

        }
        private void cardButton_CheckedChanged(object sender, EventArgs e)
        {

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

        private void comboBoxCupDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxCupDrink.Items[comboBoxCupDrink.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelectedText(selectedItem, Menu.inventoryCupDrink);
        }

        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxDrink.Items[comboBoxDrink.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
            machine.SelectedText(selectedItem, Menu.inventoryDrink);
        }
    }
}
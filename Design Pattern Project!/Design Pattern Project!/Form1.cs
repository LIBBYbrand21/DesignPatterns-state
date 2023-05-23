using Design_Pattern_Project_.State;
using Design_Pattern_Project_.Stock;

namespace Design_Pattern_Project_
{
    public partial class Form1 : Form
    {
        private HomePageState homePageState;
        private ItemDetailesState itemDetails;
        Machine machun;

        public Form1()
        {
            InitializeComponent();
            homePageState = new HomePageState(this);
            itemDetails = new ItemDetailesState(this);
            machun = new Machine(this); 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cardButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPastris_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
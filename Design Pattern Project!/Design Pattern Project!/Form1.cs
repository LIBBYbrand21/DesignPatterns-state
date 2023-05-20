using Design_Pattern_Project_.State;

namespace Design_Pattern_Project_
{
    public partial class Form1 : Form
    {
        private HomePageState homePageState;

        public Form1()
        {
            InitializeComponent();
            homePageState = new HomePageState(this);

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
    }
}
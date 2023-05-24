using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Design_Pattern_Project_.BuilderItem
{
    public abstract class DrinkBuilder
    {
        public Label drink;
        public void CreateDrink(Form1 form)
        {
            drink = form.makingDrinks;
            drink.Visible = true;
            drink.Text = "";
        }
        public Label GetDrink()
        {
            return drink;
        }
        public virtual /*async Task*/void AddSugar()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd sugar";
        }
        public virtual /*async Task*/void AddCoffee()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd coffee";
        }
        public virtual/*async Task*/ void AddWater()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd watter";
        }
        public virtual /*async Task*/void AddMilk()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd milk";
        }
        public virtual /*async Task*/void AddMilkJam()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd milk jam";
        }
        public virtual /*async Task*/void AddNut()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd nuts";
        }
        public virtual /*async Task*/void AddVanil()
        {
            //await Task.Delay(1000);
            drink.Text += "\nadd vanil";
        }
    }
}

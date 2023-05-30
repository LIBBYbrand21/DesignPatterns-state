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
            drink.Image = null;
        }
        public Label GetDrink()
        {
            return drink;
        }
        public abstract void AddPowders();
        public abstract void AddPicture();
        public abstract void AddLiquids();
        public abstract void AddExtras();
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Design_Pattern_Project_.BuilderItem
{
    public class InstantCoffeeBuilder : DrinkBuilder
    {
        public override void AddExtras()
        {
           //no extras in instant coffee
        }

        public override void AddLiquids()
        {
            drink.Text += "\nadd water";
            Task.Delay(1000).Wait();
            drink.Text += "\nadd milk";
            Task.Delay(1000).Wait();
        }

        public override void AddPowders()
        {
            drink.Text += "\nadd sugar";
            Task.Delay(1000).Wait();
            drink.Text += "\nadd instant coffee";
            Task.Delay(1000).Wait();
        }
        public override void AddPicture()
        {
            Image image1 = Image.FromFile(@"..\..\..\..\..\images\instant coffee.jpg");
            //drink.Size = new Size(image1.Width, image1.Height);
            drink.Image = image1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.BuilderItem
{
    public class BlackCoffeeBuilder : DrinkBuilder
    {
        public override void AddExtras()
        {
            //no extras in black coffee.
        }

        public override void AddLiquids()
        {
            drink.Text += "\nadd water";
            Task.Delay(500).Wait();
        }

        public override void AddPowders()
        {
            drink.Text += "\nadd sugar";
            Task.Delay(500).Wait();
            drink.Text += "\nadd black coffee";
            Task.Delay(500).Wait();
        }
        public override void AddPicture()
        {
            Image image1 = Image.FromFile("C:\\Users\\The user\\Documents\\שנה ב\\DesignPatterns\\project\\E\\9\\images\\black coffee.jpg");
            //drink.Size = new Size(image1.Width, image1.Height);
            drink.Image = image1;
        }
    }

}

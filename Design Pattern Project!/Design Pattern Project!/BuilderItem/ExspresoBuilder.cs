using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Design_Pattern_Project_.BuilderItem
{
    public class ExpresoBuilder : DrinkBuilder
    {
        public override void AddExtras()
        {
            
        }

        public override void AddLiquids()
        {
            drink.Text += "\nadd water";
            Task.Delay(500).Wait();
            drink.Text += "\nadd milk";
            Task.Delay(500).Wait();
        }

        public override void AddPowders()
        {
            drink.Text += "\nadd sugar";
            Task.Delay(500).Wait();
            drink.Text += "\nadd coffee";
            Task.Delay(500).Wait();
        }
        public override void AddPicture()
        {
            Image image1 = Image.FromFile(@"..\..\..\..\..\images\expreso.jpg");
            //drink.Size = new Size(image1.Width, image1.Height);
            drink.Image = image1;
        }
    }
}

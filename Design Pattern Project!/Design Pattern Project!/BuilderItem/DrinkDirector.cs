using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.BuilderItem
{
    public class DrinkDirector
    {
        public void Prepare(DrinkBuilder builder, Form1 form)
        {
            builder.CreateDrink(form);
            builder.AddPowders();
            builder.AddLiquids();
            builder.AddExtras();
            builder.AddPicture();
            form.homePageState.display();
            form.paymentButton.Enabled = true;
            Task.Delay(2000).Wait();
            form.makingDrinks.Visible = false;
        }
    }
}

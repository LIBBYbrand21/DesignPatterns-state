using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.BuilderItem
{
    public class DrinkDirector
    {
        public async void Prepare(DrinkBuilder builder,Form1 form)
        {
            builder.CreateDrink(form);
            builder.AddSugar();
            await Task.Delay(1000);
            builder.AddCoffee();
            await Task.Delay(1000);
            builder.AddWater();
            await Task.Delay(1000);
            builder.AddMilk();
            await Task.Delay(1000);
            builder.AddMilkJam();
            await Task.Delay(500);
            form.homePageState.display();
            form.paymentButton.Enabled = true;
            await Task.Delay(500);
            form.makingDrinks.Visible = false;
        }
    }
}

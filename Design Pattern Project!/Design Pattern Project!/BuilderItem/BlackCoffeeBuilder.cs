using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.BuilderItem
{
    public class BlackCoffeeBuilder : DrinkBuilder
    {
        public override /*async Task*/void AddMilk()
        {
            // no milk for black coffee
        }

        public override /*async Task*/void AddMilkJam()
        {
            // no milk jam for black coffee
        }
    }

}

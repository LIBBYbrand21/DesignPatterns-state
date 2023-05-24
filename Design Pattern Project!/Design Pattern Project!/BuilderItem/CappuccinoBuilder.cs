using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Design_Pattern_Project_.BuilderItem
{
    public class CappuccinoBuilder : DrinkBuilder
    {
        public override void AddVanil()
        {
            // no vanil for cappuccino
        }
        public override void AddNut()
        {
            // no nuts for cappuccino
        }
    }
}

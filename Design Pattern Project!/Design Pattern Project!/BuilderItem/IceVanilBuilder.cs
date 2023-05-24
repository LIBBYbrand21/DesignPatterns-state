using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Design_Pattern_Project_.BuilderItem
{
    public class IceVanilBuilder : DrinkBuilder
    {
        public override void AddNut()
        {
            // no nut for ice vanil
        }
    }
}

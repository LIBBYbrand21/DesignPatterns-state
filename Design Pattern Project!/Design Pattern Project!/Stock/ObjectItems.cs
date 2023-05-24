using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Stock
{
    public class ObjectItems
    {
        public List<Item> Items { get; set; }
        public double TotalPrice { get; set; }

        public ObjectItems()
        {
            Items = new List<Item>();
            TotalPrice = 0.0;
        }
    }
}

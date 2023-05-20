using DesignPatternsProject.AbstractFactory.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory.prop
{
    public class NotReadyItem : Item,ItemPrototype
    {
       

        public NotReadyItem()
        {
            Description = "Not Ready Item";
        }
        public NotReadyItem(string name, int amount, double price)
        {
            Name = name;
           // Amount = amount;
            Price = price;
            Description = "not ready item";

        }
        public Item Clone()
        {
            return new NotReadyItem
            {
                Name = Name,
                Price =Price,
                Description = Description
            };
        }
    }
}

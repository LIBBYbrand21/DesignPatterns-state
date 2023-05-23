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
        public NotReadyItem(string name,  double price)
        {
            Name = name;
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

using Design_Pattern_Project_.BuilderItem;
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
        public DrinkBuilder DrinkBuilder { get; set; }
        public NotReadyItem()
        {
            Description = "Not Ready Item";
        }
        public NotReadyItem(string name, double price, DrinkBuilder drinkBuilder) : base(name, price)
        {
            Description = "not ready item";
            this.DrinkBuilder = drinkBuilder;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory.prop
{
    public abstract class Item
    {
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual string Description { get; set; }
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public Item()
        {

        }
        public override string ToString()
        {
            return $" {Name} מחיר- {Price:C2}";
            
        }

        public static implicit operator Item(List<Item> v)
        {
            throw new NotImplementedException();
        }
    }
}

using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    public abstract class PackageDecorator:Item
    {
        protected Item item;

        public PackageDecorator(Item item)
        {
            this.item = item;
        }

        public override double Price { get => item.Price + base.Price; set => base.Price = value; }
    }
}

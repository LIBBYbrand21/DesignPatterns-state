using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    public class BagDecorator : PackageDecorator
    {
        public BagDecorator(Item item) : base(item)
        {
            this.Name = item.Name + " (in a bag)";
            this.Price = 0.5;
            this.Description = item.Description + " (in a bag)";
        }
    }
}

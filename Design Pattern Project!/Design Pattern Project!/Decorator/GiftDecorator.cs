using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    public class GiftDecorator : PackageDecorator
    {
        public GiftDecorator(Item item) : base(item)
        {
            this.Name = item.Name + " (as a gift)";
            this.Price+= 1.0;
            this.Description = item.Description + " (as a gift)";
        }
    }
}

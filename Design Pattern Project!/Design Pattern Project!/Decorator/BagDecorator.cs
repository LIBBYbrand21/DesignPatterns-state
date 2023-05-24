using Design_Pattern_Project_.Stock;
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
        public BagDecorator(ObjectItems objectSelectedItems) : base(objectSelectedItems)
        {
            foreach (var item in decoratedObject.Items)
            {
                item.Description += " (in a bag)";
            }
            decoratedObject.TotalPrice += 1.0;
        }
    }
}

using Design_Pattern_Project_.Stock;
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
        public GiftDecorator(ObjectItems objectSelectedItems) : base(objectSelectedItems)
        {
            foreach (var item in decoratedObject.Items)
            {
                item.Description += " (as a gift)";
            }
            decoratedObject.TotalPrice += 5.0;
        }
    }
}

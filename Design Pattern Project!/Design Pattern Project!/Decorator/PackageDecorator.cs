using Design_Pattern_Project_.Stock;
using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    public abstract class PackageDecorator: ObjectItems
    {
        protected ObjectItems decoratedObject;

        public PackageDecorator(ObjectItems objectSelectedItems)
        {
            this.decoratedObject = objectSelectedItems; 
        }

        
    }
}

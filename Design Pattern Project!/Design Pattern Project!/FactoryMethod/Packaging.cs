using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.FactoryMethod
{
    public abstract class Packaging:Item
    {
        protected Item _item;
        public Packaging(Item item)
        {
            _item = item;
        }
    }
}

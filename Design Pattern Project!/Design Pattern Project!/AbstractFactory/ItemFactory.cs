using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory
{
    public abstract class ItemFactory
    {
        public abstract Item CreateItem();
    }
}

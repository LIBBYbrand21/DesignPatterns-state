using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.FactoryMethod
{
    public class BagPackaging : Packaging
    {
        public BagPackaging(Item item) : base(item)
        {
            Name = $"{item.Name}(in bag)";
            Price += 0.5;
        }
    }
}

using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.FactoryMethod
{
    public class GiftPackaging : Packaging
    {
        public GiftPackaging(Item item) : base(item)
        {
            Name=$"{item.Name}(gift wrapped)";
            Price += 1.0;
        }
    }
}

using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.FactoryMethod
{
    public class PackagingFactory
    {
        public static Packaging CreatPackaging(Item item,string packagingType)
        {
            switch (packagingType)
            {
                case "bag":
                    return new BagPackaging(item);
                case "gift":
                    return new GiftPackaging(item);
                default:
                    throw new ArgumentException("Invalid packaging type");  

            }
                
        }

    }
}

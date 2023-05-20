using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory.Prototype
{
    public class ReadyItemPrototype:ItemPrototype
    {
        private Item _item;
        public ReadyItemPrototype(Item item)
        {
            _item = item;
        }
        public Item Clone()
        {
            return new ReadyItem
            {
                Name = _item.Name,
                Price = _item.Price,
                Description = _item.Description

            };
        }
    }
}

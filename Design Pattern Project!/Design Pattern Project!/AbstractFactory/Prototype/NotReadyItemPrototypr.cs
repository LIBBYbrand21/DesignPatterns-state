using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory.Prototype
{
    public class NotReadyItemPrototype : ItemPrototype
    {
        private NotReadyItem _item;

        public NotReadyItemPrototype(NotReadyItem item)
        {
            _item = item;
        }

        public Item Clone()
        {
            return new NotReadyItem
            {
                Name = _item.Name,
                Price = _item.Price,
                Description=_item.Description
            };
        }
    }
}

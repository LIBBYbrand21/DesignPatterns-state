using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace DesignPatternsProject.AbstractFactory.Decorator
{
    public interface ItemDecorator
    {
        Item AddAddition(Item item);
        Item ConvertItem(Item item);
    }
}

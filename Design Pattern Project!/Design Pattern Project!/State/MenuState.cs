using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.State
{
   public abstract class MenuState
    {
        public abstract string display();
        public abstract string selectItem();
        public abstract string processPayment();
        public abstract string endOrder();
    }
}

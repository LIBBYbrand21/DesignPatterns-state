using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.State
{
    abstract class MenuState
    {
        public abstract void display();

        public abstract void selectItem();

        public abstract void processPayment();

        public abstract void endOrder();

    }
}

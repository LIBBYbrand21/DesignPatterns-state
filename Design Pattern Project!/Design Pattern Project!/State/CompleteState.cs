using Design_Pattern_Project_.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.State
{
    public class CompleteState : MenuState
    {
        private Form1 form;
        private Machine machine;
        public CompleteState(Form1 form)
        {
            this.form = form;
        }
        public override string display()
        {
            throw new NotImplementedException();
        }
        public override string endOrder()
        {
            throw new NotImplementedException();
        }
        public override string processPayment()
        {
            throw new NotImplementedException();
        }
        public override string selectItem()
        {
            throw new NotImplementedException();
        }
    }
}

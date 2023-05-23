using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Builder
{
    public class CreditPayment : IPayment
    {
        public void ProcessPayment()
        {
            MessageBox.Show("Processing credit payment...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}

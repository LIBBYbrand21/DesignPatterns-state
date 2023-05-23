using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Builder
{
    public interface IPaymentBuilder
    {
        void BuildPaymentMethod();
        void BuildPaymentAmount();
        IPayment GetResult();
    }
}

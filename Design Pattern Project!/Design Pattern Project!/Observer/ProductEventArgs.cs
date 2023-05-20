using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class ProductEventArgs : EventArgs
    {
        public string ProductName { get; }

        public ProductEventArgs(string productName)
        {
            ProductName = productName;
        }
    }

}

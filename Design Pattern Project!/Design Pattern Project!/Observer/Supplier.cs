using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class Supplier
    {
        public string Name { get; set; }

        public void Notify(Product product)
        {
            Console.WriteLine("Inventory of {0} is running low. Please restock.", product.Name);
        }
    }


   


}

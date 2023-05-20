using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class Product
    {
        public string Name { get; set; }    
        private int inventoryCount;
        private List<Supplier> suppliers;

        public Product(string name, int initialCount)
        {
            Name = name;
            inventoryCount = initialCount;
            suppliers = new List<Supplier>();
        }

        public void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
        }

        public void RemoveSupplier(Supplier supplier)
        {
            suppliers.Remove(supplier);
        }

        public void DecrementInventory(int count)
        {
            inventoryCount -= count;
            if (inventoryCount <= 5)
            {
                NotifySuppliers();
            }
        }

        private void NotifySuppliers()
        {
            foreach (var supplier in suppliers)
            {
                supplier.Notify(this);
            }
        }
    }

}

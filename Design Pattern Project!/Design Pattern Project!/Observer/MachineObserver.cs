using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsProject.AbstractFactory.prop;

namespace DesignPatternsProject.Observer
{
    public class MachineObserver
    {
        private List<Item> items;
        public event EventHandler<ProductEventArgs> InventoryLow;
        private IReport reportFormatter;

        public MachineObserver(IReport reportFormatter)
        {
            items = new List<Item>();
            this.reportFormatter = reportFormatter;
        }

        public void PerformOperation(Item item)
        {
            // Perform operation
            items.Add(item);
        }

        public void EndOfDay()
        {
           /* foreach (var item in items)
            {
*//*
                if (item.Name <= 5)
                {
                    OnInventoryLow(new ProductEventArgs(item.Name));

                }*//*
            }*/
            //פונקציה לחישוב הזמן
            //reportFormatter.Generate(items);
        }
        /*List<Operation> low = new List<Operation>();
        public void Low()
        {
            foreach (var operation in operations)
            {
                if (operation.InventoryCount <= 5)
                {
                    low.Add(operation);

                }

            }
            reportFormatter.Generate(low);
        }*/
        protected virtual void OnInventoryLow(ProductEventArgs e)
        {
            InventoryLow?.Invoke(this, e);
        }
    }
}

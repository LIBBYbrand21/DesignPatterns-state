using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class Machine
    {
        private List<Operation> operations;
        public event EventHandler<ProductEventArgs> InventoryLow;
        private IReport reportFormatter;

        public Machine(IReport reportFormatter)
        {
            operations = new List<Operation>();
            this.reportFormatter = reportFormatter;
        }

        public void PerformOperation(Operation operation)
        {
            // Perform operation
            operations.Add(operation);
        }

        public void EndOfDay()
        {
            foreach (var operation in operations)
            {
                if (operation.InventoryCount <= 5)
                {
                    OnInventoryLow(new ProductEventArgs(operation.Name));
                   
                }
            }
            //פונקציה לחישוב הזמן
            reportFormatter.Generate(operations);

        }

        /*  List<Operation> low=new List<Operation>();
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

using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Observer
{
    public class Suppliers : IObserver
    {
        private string _name;
        public Suppliers(string name)
        {
            _name = name;
        }

        public void Update(Item item)
        {
            if (item.Supplier == _name)
            {
                Debug.Write($"Item '{item.Name}' amount is less than 5. Notify the supplier '{item.Supplier}'!");                    // Send a notification to the supplier

            }

        }

       
    }
}

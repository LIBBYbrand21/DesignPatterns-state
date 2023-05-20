using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory.prop
{
    public abstract class Item
    {
        public  string Name { get;  set; }
       // public  int Amount { get;  set; }
        public  double Price { get;  set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsProject.AbstractFactory.prop;

namespace DesignPatternsProject.Observer
{
    // Strategy pattern

    public interface IReport
    {
        void WriteToFile(Item item);
        public void DailyUpdate(Item item);
    }
}

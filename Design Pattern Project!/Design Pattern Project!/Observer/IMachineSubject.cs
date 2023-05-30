using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project_.Observer
{
    public interface IMachineSubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(Item item);
    }
}

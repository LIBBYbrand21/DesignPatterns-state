using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    // Strategy pattern

    public interface IReport
    {
        void Generate(List<Operation> operations);
    }
}

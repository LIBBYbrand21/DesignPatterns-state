using DesignPatternsProject.AbstractFactory.prop;
using DesignPatternsProject.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    internal class CsvReport : IReport
    {
        public void DailyUpdate(Item item)
        {
        }

        public void WriteToFile(Item item)
        {
            string filePath = "report.csv";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // כאן יתבצע הכתיבה של הדוח בפורמט CSV
                
            }

            Console.WriteLine($"CSV report has been saved to {filePath}");
        }
    }
}

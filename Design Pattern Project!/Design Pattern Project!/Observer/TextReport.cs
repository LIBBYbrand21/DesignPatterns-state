using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class TextReport : IReport
    {
        public void Generate(List<Operation> operations)
        {
            // Generate text report

            // ייצוג הדוח בפורמט טקסט ושמירה בקובץ
            string filePath = "report.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Operation operation in operations)
                {
                    writer.WriteLine($" Name: {operation.Name}, Price: {operation.Price}, InventoryCount: {operation.InventoryCount}, Description: {operation.Description}");
                }
            }
            Console.WriteLine($"Text report has been saved to {filePath}");
        }
    }

   

   

}

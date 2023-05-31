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
        public DateTime currentDate
        {
            get { return currentDate = DateTime.Now; }
            set { }
        }
        public string fileName;
        public string directoryPath;
        public string filePath;
        public CsvReport()
        {
            fileName = $"{currentDate.ToString("dd_MM_yyyy")}.csv";
            directoryPath = @"..\..\..\..\..\file";
            filePath = Path.Combine(directoryPath, fileName);
        }
        public void DailyUpdate(Item item)
        {

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            WriteToFile(item);
        }

        public void WriteToFile(Item item)
        {
            string filePath = "report.csv";
            using (StreamWriter writer = new(filePath))
            {
                // כאן יתבצע הכתיבה של הדוח בפורמט CSV
                writer.WriteLine($" Name: {item.Name}, Price: {item.Price}, Description: {item.Description}, Time: {DateTime.Now}\n");
                writer.Close();
                writer.Dispose();

            }

            Console.WriteLine($"CSV report has been saved to {filePath}");
        }
    }
}

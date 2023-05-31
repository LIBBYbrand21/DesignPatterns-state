using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsProject.AbstractFactory.prop;

namespace DesignPatternsProject.Observer
{
    public class TextReport : IReport
    {
        public DateTime currentDate
        {
            get { return currentDate = DateTime.Now; }
            set { }
        }
        public string fileName;
        public string directoryPath;
        public string filePath;
        public TextReport()
        {
            fileName = $"{currentDate.ToString("dd_MM_yyyy")}.txt";
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
            using (StreamWriter writer = new(filePath, true))
            {
                writer.WriteLine($" Name: {item.Name}, Price: {item.Price}, Description: {item.Description}, Time: {DateTime.Now}\n");
                writer.Close();
                writer.Dispose();
            }
            Console.WriteLine($"Text report has been saved to {filePath}");
        }
    }
}

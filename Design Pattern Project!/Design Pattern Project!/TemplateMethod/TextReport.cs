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
        public static DateTime currentDate
        {
            get { return currentDate = DateTime.Now; }
            set { }
        }
        public static string fileName
        {
            get { return fileName = $"{currentDate.ToString("dd_MM_yyyy")}.txt"; }
            set { }
        }
        public static string directoryPath
        {
            get
            { return directoryPath = @"..\..\..\..\..\file"; }
            set { }
        }
        public static string filePath
        {
            get { return filePath = Path.Combine(directoryPath, fileName); }
            set { }
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

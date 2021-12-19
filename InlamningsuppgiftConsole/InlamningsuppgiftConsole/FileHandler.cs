using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsuppgiftConsole
{
    public static class FileHandler
    {
        public static void SaveToFile(string filePath, List<MyCustomer> customers)
        {
            Console.WriteLine("Saving to file");
            File.WriteAllText(filePath, String.Empty);
            foreach (var c in customers)
            {
                File.AppendAllText(filePath, c.ConvertToCommaSeparatedList() + "\n");
            }
        }
    }
}

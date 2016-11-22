using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace demo
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const string outputPath = "../../../../Fake files/Town-names.txt";
            string[] towns = FillArrayWithNames(outputPath);
            Console.Write("Total towns in the array : ");
            Console.WriteLine(towns.Length);
            foreach (var town in towns)
            {
                Console.WriteLine("Blq blq " + town);
            }
        }

        static string[] FillArrayWithNames(string pathToFile)
        {
            List<string> townNames = new List<string>();
            StreamReader reader = new StreamReader(pathToFile);
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    townNames.Add(currentLine.Substring(0,currentLine.Length-1));
                    currentLine = reader.ReadLine();
                }
            }
            return townNames.ToArray();
        }
    }
}

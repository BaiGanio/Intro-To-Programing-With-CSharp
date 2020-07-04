using System;
using System.IO;

namespace IntroCSharp.Common.Helpers
{
    public static class FileReader
    {
        public static void PrintSingleLine(string path)
        {
            TextReader reader = new StreamReader(path);
            string currentLine = reader.ReadLine();
            Console.WriteLine(currentLine);
            reader.Close();
        }
        public static void PrintAllLines(string path)
        {
            TextReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }
}

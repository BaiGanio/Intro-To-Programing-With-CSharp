using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeSubstring
{
    class Program
    {
        private const string path =
           @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files\simple-text.txt";
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            StreamReader reader = new StreamReader(path);
            StringBuilder str = new StringBuilder();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    str.Append(line);
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine(str);
            Console.WriteLine("-------------------------------");
            string strQ = str.ToString();
            for (int i = 0; i < strQ.Length; i++)
            {
                if (strQ[i] == 'e')
                {
                    char q = strQ[i];
                    strQ = strQ.Replace(q, '6');
                }
                if (strQ[i] == 'r')
                {
                    char q = strQ[i];
                    strQ = strQ.Replace(q, '9');
                }
                if (strQ[i] == 's')
                {
                    char q = strQ[i];
                    strQ = strQ.Replace(q, 'Ф');
                }
            }
            Console.WriteLine(strQ);
        }
    }
}

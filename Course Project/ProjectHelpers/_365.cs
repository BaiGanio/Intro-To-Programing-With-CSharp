using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHelpers
{
    public class _365
    {
       public void CallEGNDemo()
        {
            const string OutputPath = @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files\fake-names.txt";
            string[] egn = FillArrayWithStudentsEGN(OutputPath);
            /* The ninth (9) digit in the EGN determines the gender. Odd for male, Even for female. */

            string rambo = egn[0];
            string day = rambo.Substring(0, 2);
            string month = rambo.Substring(2, 2);
            string year = rambo.Substring(4, 2);
            string genderDigit = rambo.Substring(8, 1);

            //string bunny = egn[1];
            //string day = bunny.Substring(0, 2);
            //string month = bunny.Substring(2, 2);
            //string year = bunny.Substring(4, 2);
            //string genderDigit = bunny.Substring(8, 1);

            //Console.WriteLine(genderDigit);

            // A 
            Console.WriteLine("Дата на раждане {0}.{1}.18{2} г.", day, month, year);
            // B
            string monthInWord = ExtractWord(int.Parse(month));
            Console.WriteLine("Дата на раждане {0}th {1} 18{2}", day, monthInWord, year);
            // C - The same like B. Just type all the days. Boring, but fact :)
            // D
            bool isFemale = IsFemale(genderDigit);
            if (isFemale)
            {
                string output = string.Format("Жената е родена на {0}.{1}.18{2} г.", day, month, year);
                Console.WriteLine(output);
            }
            else
            {
                string output = string.Format("Мъжът е роден на {0}.{1}.18{2} г.", day, month, year);
                Console.WriteLine(output);
            }
        }
        public bool IsFemale(string genderDigit)
        {
            bool isWoman;
            if (int.Parse(genderDigit) % 2 == 0)
            {
                isWoman = false;
            }
            else
            {
                isWoman = true;
            }
            return isWoman;
        }
        public string ExtractWord(int month)
        {
            string word = "";
            switch (month)
            {
                case 01:
                    word = "january";
                    break;
                case 02:
                    word = "february";
                    break;
                case 03:
                    word = "march";
                    break;
                case 04:
                    word = "april";
                    break;
                case 05:
                    word = "may";
                    break;
                case 06:
                    word = "june";
                    break;
                case 07:
                    word = "jule";
                    break;
                case 08:
                    word = "august";
                    break;
                case 09:
                    word = "september";
                    break;
                case 10:
                    word = "october";
                    break;
                case 11:
                    word = "november";
                    break;
                case 12:
                    word = "december";
                    break;
                default:
                    Console.WriteLine("WRONG DATA!!!");
                    break;
            }
            return word;
        }
        public string[] FillArrayWithStudentsEGN(string outputPath)
        {
            List<string> studentsEGN = new List<string>();
            using (StreamReader reader = new StreamReader(outputPath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] data = line.Split(' ');
                    string egn = data[2];
                    //Console.WriteLine(town);
                    studentsEGN.Add(egn);
                    line = reader.ReadLine();
                }
            }
            return studentsEGN.ToArray();
        }
    }
}

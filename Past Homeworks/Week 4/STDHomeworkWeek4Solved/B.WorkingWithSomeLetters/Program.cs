using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.WorkingWithSomeLetters
{
    class Program
    {
        // Declare and initialize variable from type Random
        static Random rand = new Random();

        static void Main(string[] args)
        {
            // Change the console output encoding, because we'll work in Bulgarian
            Console.OutputEncoding = Encoding.UTF8;

            // Declare and initialize a string array which will store 100 letters (chars)
            string[] stringArray = new string[100];

            Console.WriteLine("Даден е низ от 100 случайни букви на кирилица. Програмата показва кои гласни са широки, тесни и съставни, както и кои съгласни са звучни, беззвучни и сонорни.");
            Console.WriteLine("-------------------------------------------------------");

            // Generate 100 letters using the rand variable
            for (int i = 0; i < 100; i++)
            {
                // Notice how we generate random letters using their UTF-8 codes (capital letters not included)
                stringArray[i] = ((char)rand.Next(1072, 1103)).ToString();
                Console.Write(stringArray[i]);
            }

            Console.WriteLine("\n-------------------------------------------------------");

            // Depending what type the letter is, it wall fall in its corresponding category
            for (int i = 0; i < 100; i++)
            {
                if ((stringArray[i] == "а") || (stringArray[i] == "o") || (stringArray[i] == "е"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е широка гласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "и") || (stringArray[i] == "у") || (stringArray[i] == "ъ"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) e тясна гласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "ю") || (stringArray[i] == "я"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е съставна гласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "п") || (stringArray[i] == "ф") || (stringArray[i] == "к") || (stringArray[i] == "т") || (stringArray[i] == "ш") || (stringArray[i] == "с") || (stringArray[i] == "x") || (stringArray[i] == "ц"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е беззвучна съгласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "л") || (stringArray[i] == "м") || (stringArray[i] == "н") || (stringArray[i] == "р"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е сонорна съгласна и се намира под номер {i}.");
                }
                if ((stringArray[i] == "б") || (stringArray[i] == "в") || (stringArray[i] == "г") || (stringArray[i] == "д") || (stringArray[i] == "ж") || (stringArray[i] == "з") || (stringArray[i] == "ч"))
                {
                    Console.WriteLine($"Буквата ({stringArray[i]}) е звучна съгласна и се намира под номер {i}.");
                }
            }
        }
    }
}

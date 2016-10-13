using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDigitInCirylicAlphabet
{
    class CheckForChar
    {
        static void Main(string[] args)
        {
            Console.Write("Enter digit between 0-9 : ");
            try
            {
                char digit = char.Parse(Console.ReadLine());

                if (digit >= 48 && digit <= 57)
                {
                    Console.WriteLine("Look for more info in ASCII table from 0 ... 9 .");
                }

                Console.Write("Your number is : ");

                switch (digit)
                {
                    case '0':
                        Console.WriteLine("Zero");
                        break;
                    case '4':
                        Console.WriteLine("Four");
                        break;
                    case '9':
                        Console.WriteLine("Nine");
                        break;
                    default:
                        Console.WriteLine("There is no Data for that DIGIT.");
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("You are doing wrong! It must be digit!!! Call the Administrator.");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyGamblers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some letter or number and I will check if it is in BELOT GAME");

            string letter = Console.ReadLine();

            switch (letter)
            {
                case "7":
                    Console.WriteLine("7 => Value 0");
                    break;
                case "8":
                    Console.WriteLine("8 => Value 0");
                    break;
                case "9":
                    Console.WriteLine("9 => Value 14");
                    break;
                case "10":
                    Console.WriteLine("10 => Value 10");
                    break;
                case "J":
                    Console.WriteLine("JACK => Value 20");
                    break;
                case "Q":
                    Console.WriteLine("QUEEN => Value 3");
                    break;
                case "K":
                    Console.WriteLine("KING => Value 4");
                    break;
                case "A":
                    Console.WriteLine("ACE => Value 11");
                    break;
                default:
                    Console.WriteLine("Not it the GAME");
                    break;
            }
        }
    }
}

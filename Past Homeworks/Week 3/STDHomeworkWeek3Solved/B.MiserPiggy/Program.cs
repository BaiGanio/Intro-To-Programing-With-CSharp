using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the variables we need.
            int sumPiggyName1 = 0;
            int sumPiggyName2 = 0;
            int sumPiggyName3 = 0;

            // Take user input
            Console.WriteLine("Hey, piggies! Enter your names:");
            Console.Write("Piggy 1: ");
            string piggyName1 = Console.ReadLine();
            Console.Write("Piggy 2: ");
            string piggyName2 = Console.ReadLine();
            Console.Write("Piggy 3: ");
            string piggyName3 = Console.ReadLine();

            // Using a foreach loop, calculate the sum of each name
            foreach (char a in piggyName1)
            {
                sumPiggyName1 += a;
            }

            foreach (char b in piggyName2)
            {
                sumPiggyName2 += b;
            }

            foreach (char c in piggyName3)
            {
                sumPiggyName3 += c;
            }

            // Finally, compare the results and display a suitable message.
            if (sumPiggyName1 > sumPiggyName2 && sumPiggyName1 > sumPiggyName3)
            {
                if (sumPiggyName2 > sumPiggyName3)
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName1} ({sumPiggyName1}) followed by " +
                        $"{piggyName2} ({sumPiggyName2}) and last is {piggyName3} ({sumPiggyName3}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName1} ({sumPiggyName1}) followed by " +
                        $"{piggyName3} ({sumPiggyName3}) and last is {piggyName2} ({sumPiggyName2}).");
                }
            }
            else if (sumPiggyName2 > sumPiggyName1 && sumPiggyName2 > sumPiggyName3)
            {
                if (sumPiggyName1 > sumPiggyName3)
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName2} ({sumPiggyName2}) followed by " +
                        $"{piggyName1} ({sumPiggyName1}) and last is {piggyName3} ({sumPiggyName3}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName2} ({sumPiggyName2}) followed by " +
                        $"{piggyName3} ({sumPiggyName3}) and last is {piggyName1} ({sumPiggyName1}).");
                }
            }
            else if (sumPiggyName1 > sumPiggyName2)
            {
                Console.WriteLine($"The name-wealthiest pig is {piggyName3} ({sumPiggyName3}) followed by " +
                    $"{piggyName1} ({sumPiggyName1}) and last is {piggyName2} ({sumPiggyName2}).");
            }
            else
            {
                Console.WriteLine($"The name-wealthiest pig is {piggyName3} ({sumPiggyName3}) followed by " +
                    $"{piggyName2} ({sumPiggyName2}) and last is {piggyName1} ({sumPiggyName1}).");
            }
        }
    }
}

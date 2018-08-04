using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.TheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI; // This is how you declare and initialize a constant.
            Console.WriteLine("How old are you?");
            // We take the logic from the previous task to calculate age after 10 years.
            int age = int.Parse(Console.ReadLine());
            int ageAfter10 = age + 10;
            // Then we calculate the unique number using the given formula.
            Console.WriteLine("Enter last 4 digit of your faculty number");
            int facultyNumberLast4Digits = int.Parse(Console.ReadLine());
            double uniqueNumber = (ageAfter10 * facultyNumberLast4Digits) / pi;
            // Finally, we output the results.
            Console.WriteLine($"You will be {ageAfter10} years old after 10 years. And your unique number is " +
                $"{Math.Round(uniqueNumber, 4)}.");
        }
    }
}

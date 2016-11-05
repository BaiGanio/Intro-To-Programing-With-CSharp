using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    /* Your task is to create a program who reads a number from the console and prints if number is odd or even. */

    class Program
    {
        static void Main(string[] args)
        {
            // User try-catch to hide the exception with meaningful message. Exmp: Bugs Bunny instead of 3.14
            try
            {
                Console.WriteLine("Enter number: ");
                // If we want to hold really big integers we need to reference to System.Numerics
                // BigInteger result = BigInteger.Parse(Console.ReadLine());
                double result = double.Parse(Console.ReadLine());
                if (result % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong DATA");
            }
        }
    }
}

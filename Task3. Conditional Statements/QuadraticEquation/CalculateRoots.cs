using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class CalculateRoots
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets have some fun! Enter digits!");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("=======================================");

            Console.WriteLine();

            Console.WriteLine("First we will calculate the discriminant!");
            Console.WriteLine("The formula is: D = b^2 - 4ac");

            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            Console.WriteLine("D = {0}", discriminant);

            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else if (discriminant == 0)
            {
                double x = -(b) / 2 * a;
                Console.WriteLine("x = {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;

                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }


        }
    }
}

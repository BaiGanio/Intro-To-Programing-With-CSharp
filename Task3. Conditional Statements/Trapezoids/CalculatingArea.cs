using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class CalculatingArea
    {
        static void Main(string[] args)
        {

            /*
             * Write a program wich calculates trapezoid area bazed on User inpit.
             * Choose the most appropriate data type.
             * Print readable message with the result on the console.
             *  
             */

            Console.WriteLine("Enter three numbers to calculate trapezoid area:");

            Console.Write("Base a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Base b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Height h = ");
            double h = int.Parse(Console.ReadLine());
            double formula = ((a + b)/2)*h;
            Console.WriteLine("The formula is Area = ((a + b)/2)*h  " +
                              "\nThe area of trapezoid is: {0} square {1}",
                              formula, "kilometers");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a variable of type string which will represent the user's answer
            Console.WriteLine("Choose and option (triangle,square or radians):");
            string option = Console.ReadLine();

            // Depending on the answer, different calculations will be made
            switch (option)
            {
                /* Each option will have its own method which will do the calculations. 
                   In the cases we'll take user input and then call the corresponding method.
                   As in the previous task, it is recommended that you do some 
                   kind of validation on your own. */
                case "triangle":
                    Console.Write("Enter a side: ");
                    double triangleSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height to that side: ");
                    double triangleHeight = double.Parse(Console.ReadLine());

                    Console.WriteLine("The area of this triangle is: " + TriangleArea(triangleSide, triangleHeight));
                    break;
                case "square":
                    Console.Write("Enter a side: ");
                    double squareSide = double.Parse(Console.ReadLine());

                    Console.WriteLine("The area of this square is: " + SquareArea(squareSide));
                    break;
                case "radians":
                    Console.Write("Enter an angle in degrees: ");
                    double angleDegrees = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{angleDegrees} degrees in radians is: " + AngleInRadians(angleDegrees));
                    break;
                default:
                    Console.WriteLine("Incorrect option.");
                    break;
            }
        }

        /* Declare a method which will calculate and return the area of a triangle by given 
           side and height to that side. */
        static double TriangleArea(double tSide, double tHeight)
        {
            double triangleArea = (tSide * tHeight) / 2;

            return triangleArea;
        }

        /* Declare a method which will calculate and return the area of a square 
           by given side */
        static double SquareArea(double aSquare)
        {
            double sSquare = aSquare * aSquare;

            return sSquare;
        }

        /* Declare a method which will accept an angle in degrees and return it 
           in radians using the given formula. */
        static double AngleInRadians(double angleDeg)
        {
            double angleInRadians = Math.PI / 180 * angleDeg;

            return angleInRadians;
        }
    }
}

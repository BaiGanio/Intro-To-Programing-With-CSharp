using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declare and initialize the variables we need.
               BONUS: Figure a way to validate that the input is correct */
            Console.WriteLine("Enter 3 numbers.");
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            // Call the method which will compare the 3 numbers
            Console.WriteLine("The biggest number is: " + GetMax(firstNumber, secondNumber, thirdNumber));
        }

        /* Don't forget it is good practise to put all other methods after the Main() method. 
           Here the method will return a number (the greatest one) so that's why
           it is declared as int */
        static int GetMax(int num1, int num2, int num3)
        {
            // Compare the 3 numbers and return the greatest one
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else return num3;
        }
    }
}

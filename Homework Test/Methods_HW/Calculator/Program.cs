using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the action that you want");
            char action = char.Parse(Console.ReadLine());

            double result = 0;

            if (action == '+')
            {
                result = num1 + num2;
            }

            if (action == '-')
            {
                result = num1 - num2;
            }

            if (action == '*')
            {
                result = num1 * num2;
            }
            if (action == '/')
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is = {0}", result);
        }
    }
}

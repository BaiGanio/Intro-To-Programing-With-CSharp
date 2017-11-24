using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class _1701681077_Selin_Seid
    {
        public static void CalculateExpression_Test_1_2II()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter ß:");
            double beta = double.Parse(Console.ReadLine());
            Console.Write("Enter γ:");
            double gama = double.Parse(Console.ReadLine());
            double a = Math.Pow((Math.Sin(Math.Pow(Math.PI, 4))), 2);
            double b = Math.Pow(Math.Cos(6), (1 / 5));
            double c = Math.Abs(Math.Tan(gama));
            Console.WriteLine("The expresion is: ");
            Console.WriteLine(beta + a / b + (1 / c));
        }
    }
}

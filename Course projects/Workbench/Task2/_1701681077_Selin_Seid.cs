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
            double result = ExpressionCalculation(beta, gama,a,b,c);
            Console.Write("The expression is: ");
            Console.WriteLine(result);
        }
        public static double ExpressionCalculation(double beta, double gama,double a,double b,double c )
        {
            double result = beta + a / b + (1 / c);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
   public static class _1701681070_TatyanaAndreeva
    {
        public static void ComputationalExpression()
        {
            Console.WriteLine("Въведете две цели положителни числа!");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Въведете цяло и положително число!");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("Въведете цяло и положително число!");
                b = int.Parse(Console.ReadLine());

            }

            double result = (CalculateFunction(a + b)) * (CalculateFunction(Math.Abs(a - b)));
            Console.WriteLine("{0:F2}", result);

        }
        public static double CalculateFunction(int n)
        {
            double F = 0;
            for (int i = 1; i <= n; i++)
            {
                F = (F + Math.Pow(i, -4));
            }
            return F;
        }
    }
}

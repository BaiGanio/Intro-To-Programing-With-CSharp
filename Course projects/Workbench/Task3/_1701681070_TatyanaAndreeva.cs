using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   public static class _1701681070_TatyanaAndreeva_37_8EX
    {
        public static void BooleanExpression()
         {
            Console.Write("X=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("E=");
            double e = double.Parse(Console.ReadLine());
            Console.Write("Z=");
            double z = double.Parse(Console.ReadLine());
            bool f = Math.Sqrt((x + 1 - a * y * y) / y + x) > 0 || Math.Pow(e, y) < (z - 1) && Math.Sqrt(z - 1) <= 5;
            Console.WriteLine(f);
            Console.ReadKey(true);
        }
    }
}

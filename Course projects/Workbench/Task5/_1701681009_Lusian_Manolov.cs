using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.STD1A
{
    public static class _1701681009_Lusian_Manolov
    {
        /*a*/
        public static double DefiningAMethodCor(double x, double y)
        {
            if (x != -y)
            {
                return (Math.Abs(x) * Math.Abs(y)) / (x + y);
            }
            else return 0;
        }

        public static void UsingTheMethodCorForPerformingDifferentTasks_162()
        {
            /*b*/
            Console.WriteLine("Enter 2 numbers.");
            double p, q;

            do
            {
                Console.Write("Number 1:");
                p = double.Parse(Console.ReadLine());
                Console.Write("Number 2:");
                q = double.Parse(Console.ReadLine());

                if (p < -30 || p > 30 || q < -30 || q > 30)
                {
                    Console.WriteLine("Incorrect data. The two numbers must be between -30 and 30.");
                }
            } while ((p < -30) || (p > 30) || (q < -30) || (q > 30));

            /*c*/
            double cor = (DefiningAMethodCor(p, 3 * q) - DefiningAMethodCor(3 * p, q)) / (DefiningAMethodCor(p, q));

            if (DefiningAMethodCor(p, q) == 0)
            {
                Console.WriteLine("Cor(p,q)=0. Dividing by zero is forbidden!");
            }
            else
                Console.WriteLine("(cor(p,3*q)-cor(3*p,q))/(cor(p,q))= " + cor);

            /*d*/
            for (q = 10; q <= 50; q += 4)
            {
                double x = DefiningAMethodCor(p, q);
                if ((int)(x % 2) == 0)
                    Console.WriteLine((int)x);
            }
        }
    }
}

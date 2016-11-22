using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _225
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] someDoubles = new double[50];

            for (int i = 0; i < someDoubles.Length; i++)
            {
                double currentDouble = rnd.Next(0, int.MaxValue);
                someDoubles[i] = Math.Sqrt(currentDouble);
                Console.WriteLine(someDoubles[i]);
            }
        }
    }
}

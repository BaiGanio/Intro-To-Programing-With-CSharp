using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] someInts = new int[10];
            for (int i = 0; i < someInts.Length; i++)
            {
                someInts[i] = rnd.Next(0, int.MaxValue);
                Console.WriteLine(someInts[i] + " ");
            }
            Console.WriteLine("Biggest {0}", someInts.Max());
            Console.WriteLine("Lowest {0}", someInts.Min());
        }
    }
}

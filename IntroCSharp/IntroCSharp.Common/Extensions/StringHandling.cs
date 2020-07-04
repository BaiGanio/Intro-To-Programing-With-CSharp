using IntroCSharp.Common.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Extensions
{
    public static class StringHandling
    {
        public static void ToStringAndConvertToString()
        {
            /* This will give us empty string */
            Rabbit c1 = null;
            string str = Convert.ToString(c1);
            Console.WriteLine(str);

            /* This will cause Null Reference Exception */
            Rabbit c2 = null;
            str = c2.ToString();
            Console.WriteLine(str);
        }

        /*
     * Sinsce strings are reference types we will have variable in the STACK
     * pointing to the object in the HEAP
     * System.String is imutable. Which mean that cannot change the object in the memory.
     * System.Text.StringBuilder is mutable - no matter how many time we chain there will be the same object in the HEAP.
     */
        public static void StringAndStringBuilder()
        {
            string str = "C#";
            str += " Xa-xa=xa";
            str += " This will create";
            str += " as much objects in the HEAP";
            str += " as much concatenations we do.";

            Console.WriteLine(str);

            Console.WriteLine("----------------------");
            Console.WriteLine("How time we will need to concatenate 50 000 times?");
            Console.WriteLine("----------------------");

            /* Create new stopwatch */
            Stopwatch stopwatch = new Stopwatch();
            string a = String.Empty;

            Console.Write("String concatenation time: ");
            /* Begin timing */
            stopwatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                a += "Bugs Bunny";
            }
            /* Stop timing */
            stopwatch.Stop();

            /* Show the result */
            Console.WriteLine("{0}", stopwatch.Elapsed);


            Console.WriteLine("-------------------------------------------");
            Stopwatch stopwatch1 = new Stopwatch();
            Console.Write("StringBuilder concatenation time: ");
            StringBuilder sb = new StringBuilder();

            /* Begin timing */
            stopwatch1.Start();
            for (int i = 0; i < 50000; i++)
            {
                sb.Append("Bugs Bunny");
            }
            /* Stop timing */
            stopwatch1.Stop();

            /* Show the result */
            Console.WriteLine("{0}", stopwatch1.Elapsed);
        }
    }
}

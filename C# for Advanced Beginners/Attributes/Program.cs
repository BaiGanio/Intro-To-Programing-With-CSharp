using System;
using System.Collections.Generic;

namespace Attributes
{
    /*
     * Attributes allow us to add declarative information to our program.
     * This information can be queried at runtime using reflection
     * Attributes are customizable using parameters
     */
    class Program
    {
        static void Main()
        {
            /* What if we want to pass 20 arguments? */
            int jo = Calculator.Add(20, 30);
            Console.WriteLine(jo);
            /* Lead to compile time error */
            //Calculator.Add(10, 15, 5);
            jo = Calculator.Add(new List<int> {10, 20, 30});
            Console.WriteLine(jo);
        }
    }

    class Calculator
    {
        [Obsolete("Use Add(List<int> numbers)")]
        public static int Add(int fN, int sN)
        {
            return fN + sN;
        }
        /* True mean that if someone try to use this method to throw error */
        [Obsolete("Use Add(List<int> numbers)", true)]
        public static int Add(int fN, int sN, int tN)
        {
            return fN + sN + tN;
        }
        /* What if we want to pass 20 arguments? */
        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}

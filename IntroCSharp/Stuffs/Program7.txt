using System;

namespace MethodOverloading
{
    /*
     * Methods can be overloaded by the numbers of parameters also & the type of parameters (int, float). It can be overloaded based on the kind of the parameters -> value, ref, out, params array ...
     * !!! It's not possible to overload method based on the return type or marams modifier
     */
    class Program
    {
        static void Main()
        {
            float testVar = 0;
            CalcSum(5, 6);
            CalcSum(5, 10, ref testVar);
            Console.WriteLine("Result from method overloading with 'ref' type variable: {0}", testVar * 10);
        }

        public static void CalcSum(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("Sum is: {0}", result);
        }
        public static void CalcSum(float n1, float n2, int n3)
        {
            float result = n1 + n2 + n3;
            Console.WriteLine("Sum is: {0}", result);
        }

        /* This will give us compile-time error */
        //public static float CalcSum(float n1, float n2, int n3)
        //{
        //    float result = n1 + n2 + n3;
        //    Console.WriteLine("Sum is: {0}", result);
        //}

        public static void CalcSum(float n1, float n2, ref float n3)
        {
            n3 = n1 + n2;
            Console.WriteLine("Sum is: {0}", n3);

        }

    }
}

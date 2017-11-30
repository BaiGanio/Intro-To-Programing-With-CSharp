using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.STD3A
{
    public static class _1701681077_Selin_Seid
    {
        public static object CalculateArrayC { get; private set; }

        public static void CalculateAverageOfAnArray_408()
        {

            int arrayLength = 3;
           
            Console.WriteLine("Въведете елементите на масив А");
            double[] a = EnterArray(arrayLength);
            Console.WriteLine($"Средноаритметичното на елементите на масив A:{Average(a)}");

            Console.WriteLine("Въведете елементите на масив B");
            double[] b = EnterArray(arrayLength);
            Console.WriteLine($"Средноаритметичното на елементите на масив B:{Average(b)}");
           
            Console.WriteLine("Въведете елементите на масив C");
            double[] c = EnterArray(arrayLength);
            Console.WriteLine($"Средноаритметичното на елементите на масив C:{Average(c)}");
            
            Console.WriteLine("Максималното Средноаритметично е:");
            CalculateMaxAverage(a, b, c, arrayLength);
            CalculateExpressionForArrayC(arrayLength, a, b, c);
            Console.WriteLine();
        }

        public static void CalculateMaxAverage(double[] a, double[] b, double[] c, int arrayLenght)
        {
            double maxAverage;
            if (Average(a) > Average(b))
            {
                maxAverage = Average(a);
            }
            else
            {
                maxAverage = Average(b);
            }
            if (Average(c) > maxAverage)
            {
                maxAverage = Average(c);
            }
            Console.WriteLine(maxAverage);
           foreach (var item in c)
            {
                Console.Write(item + " ");
            }
        }
        public static void CalculateExpressionForArrayC(int arrayLength, double[] a, double[] b, double[] c)
            {
            int j = 0, n = arrayLength;
            while (j != n)
                 {
                     for (int i = 0; i < n; i++)
                     {
                    c[j] = a[i] + (((n * n) + 1) * b[n - 1]);
                    arrayLength--;
                    j++;
                     }

                 }
            }
        public static double[] EnterArray(int arrayLength)
        {
            double[] a = new double[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {

                Console.Write("arr[" + i + "]=");
                a[i] = double.Parse(Console.ReadLine());
               
            }
            return a;
        }
        public static double Average(double[] a)
        {
            double average = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= -100 && a[i] <= 100)
                {
                    average = average + a[i];
                    count++;
                }
            }
            average = average / count;
            return average;
        }
    }
}

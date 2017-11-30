using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.STD3A
{
    public static class _1701681077_Selin_Seid
    {
        public static void CalculateAverageOfAnArray_408()
        {

            int arr = 3;
            double[] A = new double[arr];
            double[] B = new double[arr];
            double[] C = new double[arr];
            Console.WriteLine("Въведете елементите на масив А");
            EnterArray(A);
            Console.WriteLine("Въведете елементите на масив В");
            EnterArray(B);
            Console.WriteLine("Въведете елементите на масив С");
            EnterArray(C);
            Console.WriteLine("Средноаритметичното на елементите на трите масива:");
            Console.WriteLine("Масив А: " + Average(A));
            Console.WriteLine("Масив В: " + Average(B));
            Console.WriteLine("Масив С: " + Average(C));
            Console.WriteLine("Максимакното Средноаритметично е:");
            double maxAverage;
            if (Average(A) > Average(B))
            {
                maxAverage = Average(A);
            }
            else
            {
                maxAverage = Average(B);
            }
            if (Average(C) > maxAverage)
            {
                maxAverage = Average(C);
            }
            Console.WriteLine(maxAverage);
            int j = 0, n = arr;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    C[j] = A[i] + (((n * n) + 1) * B[n - 1]);
                    arr--;
                    j++;
                }

            } while (j != n);
            foreach (var item in C)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        internal static void EnterArray(object a)
        {
            throw new NotImplementedException();
        }

        public static void EnterArray(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("arr[" + i + "]=");
                a[i] = double.Parse(Console.ReadLine());
            }
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

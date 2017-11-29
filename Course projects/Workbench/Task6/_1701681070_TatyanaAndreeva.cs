using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
   public static class _1701681070_TatyanaAndreeva
    {
        public static void HydrologicalStations()
        {
            int n = 0;
            while (n < 1 || n > 31) ;
            {
                Console.WriteLine("Въведете брой дни в месеца: ");
                n = int.Parse(Console.ReadLine());
            } 
            Console.WriteLine("Елементи за станция А: ");
            double[] A = new double[n];
            Rain(A);
            Console.WriteLine("Средното количество  валежи за станция А е: {0}", Average(A));
            MaxRain(A);
            Console.WriteLine("Елементи за станция B: ");
            double[] B = new double[n];
            Rain(B);
            Console.WriteLine("Средното количество  валежи за станция B е: {0}", Average(B));
            MaxRain(B);
            Console.WriteLine("Елементи за станция С: ");
            double[] C = new double[n];
            Rain(C);
            Console.WriteLine("Средното количество  валежи за станция C е: {0}", Average(C));
            MaxRain(C);
        }
        public static void Rain(double[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }
        }
        public static double Average(double[] input)
        {
            double average = 0;
            for (int i = 0; i < input.Length; i++)
            {
                average += input[i];
            }
            return (average / input.Length);
        }
        public static void MaxRain(double[] input)
        {
            double max = Average(input);
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    count++;
                    Console.WriteLine("Броят на дните,които са надхвърлили средното количество валежи е {0}", count);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.STD3A
{
    public static class _1701681077_Selin_Seid
    {
        public static void Generate_Random_Numbers_5_377()
        {
            Random random = new Random();
            Console.WriteLine("The negative generated numbers are: ");
            for (int i = 1; i <= 55; i++)
            {
                int number = random.Next(-100, 101);

                if (number < 0)
                {
                    Console.Write(number);
                }
            }
            Console.WriteLine();
            double sum = 0;
            double average = 0;
            int count = 0;
            Console.WriteLine("Please enter 13 numbers: ");
            for (int i = 1; i <= 13; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > 0 || number < -300)
                {
                    count++;
                    sum += number;
                }
            }
            average = sum / count;

            Console.WriteLine($"The average is: {average}");
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Pro(Math.Abs(a - b)) * Pro(c));
        }

        static double Pro(int k)
        {
            Random random = new Random();
            double product = 1;

            for (int i = 1; i <= k; i++)
            {
                int numbers = random.Next();
                if (numbers >= -10 && numbers <= 10)
                {
                    product *= numbers;
                }
            }

            return product;
        }
    }
}

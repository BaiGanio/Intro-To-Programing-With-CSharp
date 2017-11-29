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
            for (int randomNumbers = 1; randomNumbers <= 55; randomNumbers++)
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
            for (int numbers = 1; numbers <= 13; numbers++)
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
            Console.WriteLine(Product(Math.Abs(a - b)) * Product(c));
        }

        static double Product(int k)
        {
            Random random = new Random();
            double product = 1;

            for (int randomNumbers = 1; randomNumbers <= k; randomNumbers++)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.PiggyBank
{
    class Program
    {
        // Declare and initialize variable from type Random.
        static Random rand = new Random();

        static void Main(string[] args)
        {
            // Declare and initialize the variables we need.
            double number;
            double sqrtNumber;
            double sum = 0;

            // The core of the program will be a for loop, which will display
            // the number for each day. We'll assume that the days in every month are 31.
            for (int i = 1; i <= 31; i++)
            {
                // Note how we generate random double numbers
                number = rand.NextDouble() * rand.Next(1, 998001);
                sqrtNumber = Math.Sqrt(number);
                Console.WriteLine($"The number for day {i} is: {Math.Round(number, 4)} (sqrt={Math.Round(sqrtNumber, 4)}).");

                // After the number is generated, check in which range its square root falls
                // and make the relevant calculations. Don't forget to edit the output.
                if (sqrtNumber >= 1 && sqrtNumber <= 300)
                {
                    sqrtNumber *= 5.1f;
                    Console.WriteLine("Bonus for this number is {0:F4}", sqrtNumber);
                    sum += sqrtNumber;
                }
                else if (sqrtNumber > 300 && sqrtNumber <= 600)
                {
                    sqrtNumber *= 10.098f;
                    Console.WriteLine("Bonus for this number is {0:F4}", sqrtNumber);
                    sum += sqrtNumber;
                }
                else if (sqrtNumber > 600 && sqrtNumber <= 999)
                {
                    sqrtNumber *= 100.00001f;
                    Console.WriteLine("Bonus for this number is {0:F4}", sqrtNumber);
                    sum += sqrtNumber;
                }
                Console.WriteLine("------------------------------------------");
            }

            // Display the total sum for one month and calculate the annual sum
            Console.WriteLine("The bonus for this month is: " + Math.Round(sum, 4));

            double yearlySum = sum * 12;

            Console.WriteLine("Annual sum = " + Math.Round(yearlySum, 4));

            // Check if the annual sum is more than 1000000 and display a message if it is.
            if (yearlySum > 1000000)
            {
                Console.WriteLine("Hooray, piggies, your savings for 1 year are more than 1 000 000!!!");
            }
            else Console.WriteLine("Piggies, your savings for 1 year are less than 1 000 000.");
        }
    }
}

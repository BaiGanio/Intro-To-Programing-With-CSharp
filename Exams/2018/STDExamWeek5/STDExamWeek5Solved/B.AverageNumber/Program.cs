using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the variables we need.
            int number;
            int evenNumbersCount = 0;
            double evenNumbersSum = 0;
            bool inputIsNumber;

            Console.WriteLine("Enter some numbers. When you're done, enter 0.");

            // Make a do-while loop, which will repeat itself until the input number is 0.
            do
            {
                Console.WriteLine("Enter a number: ");
                // If the input is a number, inputIsNumber will be true. If it's not the loop will iterate one more time.
                inputIsNumber = int.TryParse(Console.ReadLine(), out number);

                // Check if the input number is between 1 and 255 and if it is even.
                if ((number >= 1 && number <= 255) && (number % 2 == 0))
                {
                    evenNumbersSum += number;
                    evenNumbersCount++;
                }
            } while (number != 0 || !inputIsNumber);
            
            // Check if there are any even numbers between 1 and 255. If there aren't, display a suitable message.
            // If there are, calculate the average and display it.
            if (evenNumbersCount == 0)
            {
                Console.WriteLine("There aren't any even numbers between 1 and 255.");
            }
            else
            {
                double evenNumbersAverage = evenNumbersSum / evenNumbersCount;
                Console.WriteLine("The average of the even numbers between 1 and 255 is: " + evenNumbersAverage);
            }
        }
    }
}

using System;

namespace STD_LusianManolov_1701681009_H2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 7-digit number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the input number has 7 digits
            if (number < 1000000 || number > 9999999)
            {
                // If it hasn't, display a suitable message
                Console.WriteLine("The number you entered is not a 7-digit number!");
            }
            else
            {
                /* If it has, find the fourth digit. You can search the Internet
                   for another and better algorithm for finding the 4th digit. */
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;

                Console.WriteLine($"The 4th digit of {number} is {fourthDigit}");
            }
        }
    }
}

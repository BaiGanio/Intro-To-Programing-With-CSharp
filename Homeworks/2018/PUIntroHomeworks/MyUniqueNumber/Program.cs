using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int last4Digits = int.Parse(Console.ReadLine());

            double result = MyUniqueNumber(AgeAfter10Years(age), last4Digits);

            Console.WriteLine("After 10 years you will be " + AgeAfter10Years(age) + " years old. " +
                "And your unique number is: " + result);
        }

        static int AgeAfter10Years(int currentAge)
        {
            int ageAfter10Years = 0;

            // Do calculations here.

            return ageAfter10Years;
        }

        static double MyUniqueNumber(int ageAfter10Years, int last4DigitsOfFacNumber)
        {
            double myUniqueNumber = 0;

            // Do calculations here.

            return myUniqueNumber;
        }
    }
}

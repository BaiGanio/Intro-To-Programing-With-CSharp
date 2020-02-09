using System;

namespace PreventExceptionHandlingAbuse
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter NUMERATOR:");
                int numerator;
                bool isNumeratorConverted = Int32.TryParse(Console.ReadLine(), out numerator);

                if (isNumeratorConverted)
                {
                    Console.WriteLine("Please enter DENOMERATOR:");
                    int denumerator;
                    bool isDenumeratorConverted = Int32.TryParse(Console.ReadLine(), out denumerator);
                    if (isDenumeratorConverted && denumerator != 0)
                    {
                        int result = numerator / denumerator;
                        Console.WriteLine("Result is: " + result);
                    }
                    else
                    {
                        if (denumerator == 0)
                        {
                            Console.WriteLine("Denomerator cannot be zero!");
                        }
                        else
                        {
                            Console.WriteLine("The denomerator should be between {0} & {1}", int.MinValue, int.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The numerator should be between {0} & {1}", int.MinValue, int.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

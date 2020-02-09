using System;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main()
        {
            /* This example is abuse */
            try
            {
                Console.WriteLine("Please enter NUMERATOR:");
                char z = char.Parse(Console.ReadLine());
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter DENOMINATOR:");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator/denominator;
                Console.WriteLine("Result is: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers allowed!");
            }
            /* This handle the range of the allowed numbers */
            catch (OverflowException)
            {
                Console.WriteLine("The number should be between {0} & {1}", int.MinValue, int.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine($"The unique number is: {rnd.Next(10, 10000)}");
        }
    }
}

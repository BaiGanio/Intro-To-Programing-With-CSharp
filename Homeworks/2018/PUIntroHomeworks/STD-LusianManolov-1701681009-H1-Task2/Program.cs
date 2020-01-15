using System;

namespace STD_LusianManolov_1701681009_H1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            /* Declare and initialize a variable from type integer which will store 
               your current age. Then display in the console age + 10 with a suitable message. */
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You will be {age + 10} years old after 10 years.");
        }
    }
}

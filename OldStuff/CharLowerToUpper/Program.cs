using System;

namespace SaveMySkin30
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            Console.WriteLine("Enter letter in the console:");
            letter = char.Parse(Console.ReadLine());
            char letterToLower = (char)(letter - 'a' + 'A');
            Console.WriteLine("The capital letter is {0}", letterToLower);
        }
    }
}

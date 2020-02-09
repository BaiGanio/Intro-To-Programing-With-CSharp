using System;
using System.Text;
using AssemblyOne;
using AssemblyTwo;

namespace AccessModifiersDemo
{
    /*
     * Add reference to AssemblyOne & AssemblyTwo
     */
    class Program

    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            CartoonCharacters something = new CartoonCharacters();
            something.SimpleMethod();

            Console.WriteLine("--------------------------------------");

            Class1 c1 = new Class1();
            c1.PrintYa();

        }
    }
}

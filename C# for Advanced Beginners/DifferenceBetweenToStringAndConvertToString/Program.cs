using System;

namespace DifferenceBetweenToStringAndConvertToString
{
    /*
     * Convert.ToString() handles NULL
     * ToString() doesn't handles NULL
     */
    class Program
    {
        static void Main()
        {
            /* This will give us empty string */
            Customer c1 = null;
            string str = Convert.ToString(c1);
            Console.WriteLine(str);

            /* This will cause Null Reference Exception */
            Customer c2 = null;
            str = c2.ToString();
            Console.WriteLine(str);

        }
    }

    class Customer
    {
        public string Name { get; set; } 
    }
}

using System;
using System.Text;

namespace MethodParameters
{
    /*
        There are four different types of parameters that method cah have: 
        1. Value parameters: creates a copy of the parameter passed, so modification doesn't affect each other.
        2. Reference parmeters: The 'ref' keyword causes a method to refer to the same variable that is passed into the method. Any changes made to the parameter in the method  will be reflected in that variable when control passes back to the calling method.
        3. Out parameters: used when we want a method to return more than one value.
        4. Parameters Array.

    */
    
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int i = 13;

            /* Pass by value */
            ValueMethod(i);
            Console.WriteLine(i);
            Console.WriteLine("----------------------");

            /* Pass by reference */
            ReferenceValueMethod(ref i);
            Console.WriteLine(i);
            Console.WriteLine("----------------------");

            /* Out parameters */
            int sum, multiply;
            Calculate(12, 10, out sum, out multiply);
            Console.WriteLine("The sum is {0} & the multiply is {1}", sum, multiply);
            Console.WriteLine("----------------------");

            /* Method with array of parameters */
            string[] towns = {"Пловдив", "Аксаково", "Каспичан", "Брацигово"};
            ParamsMethod();
            Console.WriteLine("----------------------");
            ParamsMethod(towns);
            Console.WriteLine("----------------------");

            /* When we call the method we give him (optional) a set of arguments */
            ParamsMethod("1", "2", "3");

        }

        /* When we create/declare a method we give him (optional) a set of parameters */
        public static void ParamsMethod(params string[] names) 
        {
            Console.WriteLine("There are {0} elements!", names.Length);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        /* Method with 'out' keyword */
        public static void Calculate(int firstNum, int secondNum, out int sum, out int multiply)
        {
            sum = firstNum + secondNum;
            multiply = firstNum * secondNum;
        }

        public static void ValueMethod(int number)
        {
            number = 69;
        }
        public static void ReferenceValueMethod(ref int number)
        {
            number = 69;
        }
    }
}

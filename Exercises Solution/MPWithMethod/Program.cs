using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name and last name:");
            string name = Console.ReadLine();

            CalculateNameLength(name);
            int nameValue = CalculateName(name);

            Console.WriteLine("Sum of all characters in the name = {0}", nameValue);

        }

        public static void CalculateNameLength(string someName)
        {
            int nameLength = someName.Length;
            Console.WriteLine("The name {0} have {1} characters", someName, nameLength -1);
        }

        public static int CalculateName(string someName)
        {
            int nameValue = 0;
            for (int i = 0; i < someName.Length; i++)
            {
                nameValue += (int)someName[i];
            }

            return nameValue;
        }
    }
}

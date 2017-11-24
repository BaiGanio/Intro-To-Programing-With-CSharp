using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class _1701681077_Selin_Seid
    {
        public static void ConvertToBinary()
        {
            int number = 2077;
            Console.WriteLine($"{(int)number} in binary code: {Convert.ToString(number, 2)}");
        }

        public static void ConvertToOctal()
        {
            int number = 2077;
            string result = "";
            while (number != 0)
            {
                result = (number % 8).ToString() + result;
                number = number / 8;
            }
            Console.WriteLine("2077 in octal code is: " + result);
        }

        public static void ConvertToHex()
        {
            int number = 2077;
            string hex = "";
            while (number != 0)
            {
                if ((number % 16) < 10)
                    hex = number % 16 + hex;
                else
                {
                    string s = "";
                    switch (number % 16)
                    {
                        case 10: s = "A"; break;
                        case 11: s = "B"; break;
                        case 12: s = "C"; break;
                        case 13: s = "D"; break;
                        case 14: s = "E"; break;
                        case 15: s = "F"; break;
                    }

                    hex = s + hex;
                }

                number /= 16;
            }
            Console.WriteLine("The number in hexadecimal code is: " + hex);
        }
    }
}

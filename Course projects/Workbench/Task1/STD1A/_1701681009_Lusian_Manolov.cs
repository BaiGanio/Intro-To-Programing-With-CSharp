using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.STD1A
{
    public static class _1701681009_Lusian_Manolov
    {
        public static void ConvertToBinary()
        {
            int number = 2009;
            Console.WriteLine(number + " in binary system is " + Convert.ToString(number, 2));
        }

        public static void ConvertToOctal()
        {
            int number = 2009;
            Console.WriteLine(number + " in octal system is " + Convert.ToString(number, 8));
        }

        public static void ConvertToHex()
        {
            int number = 2009;
            Console.WriteLine(number + " in hexadecimal system is " + Convert.ToString(number, 16));
        }

        public static void ConvertToDifferentNumeralSystems()
        {
            ConvertToBinary();
            ConvertToOctal();
            ConvertToHex();
        }
    }
}

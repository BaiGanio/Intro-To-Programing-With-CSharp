using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class _1701681070_TatyanaAndreeva
    {
        public static void ConvertToBinary()
        {
            int facNumber = 2070;
            Console.WriteLine($"{facNumber} is binary code: {Convert.ToString(facNumber, 2)}");
        }
        public static void ConvertToOcta()
        {
            int facNumber = 2070;
            Console.WriteLine($"{facNumber} is octa code: {Convert.ToString(facNumber,8)}");
        }
        public static void ConvertToHexa()
        {
            int facNumber = 2070;
            Console.WriteLine($"{facNumber} is hexa code: {Convert.ToString(facNumber,16)}");
        }

    }
}

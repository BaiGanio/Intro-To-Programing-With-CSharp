using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.STD1A
{
    public static class _1701681009_Lusian_Manolov
    {
        public static void DisplayFigure_87D()
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("{0," + (8 - i) + "}", "*");
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

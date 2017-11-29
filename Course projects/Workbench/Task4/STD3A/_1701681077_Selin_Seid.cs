using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.STD3A
{
    public static class _1701681077_Selin_Seid
    {
        public static void Triangle_Figure_Using_Stars_87_d()
        {
            for (int width = 13; width >= 1; width--)
            {
                Console.Write("{0," + width + "}", "*");
                for (int j = 1; j <= 13 - width; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}

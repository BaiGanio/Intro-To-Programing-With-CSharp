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
            for (int i = 13; i >= 1; i--)
            {
                Console.Write("{0," + i + "}", "*");
                for (int j = 1; j <= 13 - i; j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.STD1A
{
    public static class _1701681009_Lusian_Manolov
    {
        public static void DisplayTriangleUsingStars_87D()
        {
            for (int figureHeight = 1; figureHeight <= 7; figureHeight++)
            {
                Console.Write("{0," + (8 - figureHeight) + "}", "*");
                for (int j = 1; j < figureHeight; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < figureHeight - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

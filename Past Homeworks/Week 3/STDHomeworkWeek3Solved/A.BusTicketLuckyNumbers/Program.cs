using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the variables we need
            int luckyTicketsCount = 0;
            int unluckyTicketsCount = 0;

            /* Create a for loop, which will check if the sum of the first 3 digits
               is equal to the sum of the last 3 digits. If the sums are equal, the
               ticket is lucky and we'll display. If not, it is considered an unlucky ticket. */
            for (int i = 0; i < 1000000; i++)
            {
                if ((i / 100000 + i % 100000 / 10000 + i % 100000 % 10000 / 1000) == (i % 100000 % 10000 % 1000 / 100 + i % 100000 % 10000 % 1000 % 100 / 10 + i % 10))
                {
                    Console.WriteLine(i);
                    luckyTicketsCount++;
                }
                else
                {
                    unluckyTicketsCount++;
                }
            }

            // Finally, display the number of lucky and unlucky tickets and their sum.
            Console.WriteLine("The number of lucky tickets is: " + luckyTicketsCount);
            Console.WriteLine("The number of unlucky tickets is: " + unluckyTicketsCount);
            Console.WriteLine($"Total tickets: {luckyTicketsCount + unluckyTicketsCount}");
        }
    }
}

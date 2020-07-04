using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Extensions
{
    public static class MeasureExecutionTime
    {
        public static void DoJob()
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            /* Code fragment to be tested. Returned result is in miliseconds. */
            for (long i = 0; i < 500000000; i++)
            {
                sum += 10;
            }

            int endTime = Environment.TickCount;
            var elapsedTime = (endTime - startTime) / 1000.000;
            Console.WriteLine("Time elapsed : {0} sec.", elapsedTime);
            Console.WriteLine("Result: " + sum);
        }
    }
}

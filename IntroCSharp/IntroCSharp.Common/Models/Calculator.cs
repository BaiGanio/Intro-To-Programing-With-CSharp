using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Models
{
    public class Calculator
    {
        [Obsolete("Use Add(List<int> numbers)")]
        public static int Add(int fN, int sN)
        {
            return fN + sN;
        }
        /* True mean that if someone try to use this method to throw error */
        [Obsolete("Use Add(List<int> numbers)", true)]
        public static int Add(int fN, int sN, int tN)
        {
            return fN + sN + tN;
        }
        /* What if we want to pass 20 arguments? */
        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}

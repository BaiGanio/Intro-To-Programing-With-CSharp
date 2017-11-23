using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
  public static class _1701681070_TatyanaAndreeva_ex12
    {
        public static void FourthDigit()
        {
            Console.WriteLine("Enter number with 7 digits:");
            int myDigits = int.Parse(Console.ReadLine());
            int FourthNumber = (myDigits / 1000) % 10;
            Console.WriteLine("The 4-th digit is {0}", FourthNumber);

        }
    }
}

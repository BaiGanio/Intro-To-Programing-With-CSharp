using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class _1701681077_Selin_Seid
    {
        public static void Calculate_InterestRate_65()
        {
            Console.WriteLine("Enter the number of month:");
            int month = int.Parse(Console.ReadLine());
            SwitchMonth(month);
           
        }
        public static void SwitchMonth(int month)
        {
            double intRate = 0;
            switch (month)
            {
                
                case 1:
                case 12:
                    intRate = 3.8;
                    break;
                case 2:
                case 3:
                case 4:
                    intRate = 3.5;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    intRate = 4.1;
                    break;
                case 9:
                case 10:
                case 11:
                    intRate = 4.9;
                    break;
                default:
                    Console.WriteLine("Unvalid number of month!");
                    break;
            }
             Console.WriteLine("The interest rate is: " + intRate);
        }
           
        
    }
}

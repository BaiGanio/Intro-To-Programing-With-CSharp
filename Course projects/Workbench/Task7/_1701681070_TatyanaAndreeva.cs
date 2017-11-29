using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
   public static class _1701681070_TatyanaAndreeva
    {

        public static int ReturnWord()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("Числото е нула"); break;
                case 1:
                    Console.WriteLine("Числото е едно"); break;
                case 2:
                    Console.WriteLine("Числото е две"); break;
                case 3:
                    Console.WriteLine("Числото е три"); break;
                case 4:
                    Console.WriteLine("Числото е четири"); break;
                case 5:
                    Console.WriteLine("Числото е пет"); break;
                case 6:
                    Console.WriteLine("Числото е шест"); break;
                case 7:
                    Console.WriteLine("Числото е седем"); break;
                case 8:
                    Console.WriteLine("Числото е осем"); break;
                case 9:
                    Console.WriteLine("Числото е девет"); break;
                default: Console.WriteLine("Числото не е положително или едноцифрено!"); break;
            }
            return number;
        }
    }
}

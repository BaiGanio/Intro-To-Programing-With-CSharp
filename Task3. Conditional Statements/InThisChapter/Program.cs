using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InThisChapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            /*
             
             Implicit & Explicit Conversion:
             
             int i = 1;
             IMPLICIT CONVERSION
             float f = i + 0.007f;             
             Console.WriteLine(f);
             EXPLICIT CONVERSION
             int i2 = (int) f;
             Console.WriteLine(i2);
             
             */

            /*             
             Conditional statements if and if-else are conditional control statements. 
             Because of them the program can behave differently based on a defined 
             condition checked during the execution of the statement.                       
             */

            //  if (Boolean expression)
            //  {
            //      Body of the conditional statement;
            //  }   

            //  if (булев израз)
            //  {
            //        тяло на условната конструкция;
            //  }
            //  else
            //  {
            //        тяло на else-конструкция;
            //  }

            int busNUmber = int.Parse(Console.ReadLine());
           // int busNumber = 55;
            if (busNUmber == 44)
            {
                Console.WriteLine("This bus goes to the university!");
            }
            else if (busNUmber == 99)
            {
                Console.WriteLine("This bus also goes to the university!");
            }
            else if (busNUmber == 00)
            {
                Console.WriteLine("This is a joke. This stands for WC in some cases.");
            }
            else
            {
                Console.WriteLine("There is no data for this number!");
            }

            //  switch (селектор)
            //  {
            //      case стойност:
            //          конструкция;
            //          break;
            //      case стойност-2:
            //          конструкция;
            //          break;
            //      case стойност-3:
            //          конструкция;
            //          break;
            //      case стойност-4:
            //          конструкция;
            //          break;
            //      // …
            //      default:
            //          конструкция;
            //          break;
            //  }

            //try
            //{
            //    StreamReader sr = File.OpenText("data.txt");
            //    Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
            //    sr.Close();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An error occurred! ");
            //}

            //try
            //{
            //    int five = int.Parse(Console.ReadLine());
            //    Console.WriteLine("The number is {0}", five);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Грешка в изпълнението на програмата! ->> {0}. Очакваният тип данни е integer type.", ex);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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
             Implicit & Explicit Type Conversion:
             */

            Console.WriteLine("Implicit & Explicit Type Conversion:");
            int x = 6;
            Console.WriteLine("int x = {0}", x);
            //IMPLICIT CONVERSION
            double y = x + Math.PI;
            Console.WriteLine("double y = x + {0} = {1}", Math.PI, y);
            //EXPLICIT CONVERSION
            int z  = (int)y;
            Console.WriteLine("int z = (int) y = {0}", z);

            Console.WriteLine("=============================================");


            Console.WriteLine("******************************************");
            /*             
             Conditional statements if and if-else are conditional control statements. 
             Because of them the program can behave differently based on a defined 
             condition checked during the execution of the statement.                       
             */
            Console.Write("ENTER BUS NUMBER BETWEEN 0 & 100 : ");
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

            Console.WriteLine("******************************************");


            Console.WriteLine("-----------------------------------------------");
            /* Операторът switch сравнява резултата от селек­тора с всяка една стойност
             * от изброените в тялото на switch конструкцията 'case' етикети. 
             * Ако не се открие съвпадение, се изпълнява default конструкцията  */
            Console.Write("ENTER CAPITAL & I'LL GUESS THE COUNTRY : ");

            string capitalCity = Console.ReadLine();
            int lettersInCapitalName = capitalCity.Length;
            Console.WriteLine("Your city have {0} letters", lettersInCapitalName);

            switch (capitalCity)
            {
                case "Аксаково" :
                    Console.WriteLine("{0} е в България", capitalCity);
                    break;
                case "Paris":
                    Console.WriteLine("{0} is in France", capitalCity);
                    break;
                case "Sidney":
                    Console.WriteLine("{0} is in Australia", capitalCity);
                    break;
                case "Plovdiv":
                    Console.WriteLine("{0} is in Bulgaria", capitalCity);
                    break;
                default:
                    Console.WriteLine("THERE IS NO DATA...");
                    break;
            }

            Console.WriteLine("-----------------------------------------------");


            /* Handle custom exceptions */
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Handle custom exceptions");
            try
            {
                Console.Write("ENTER SOME NAME INSTEAD OF NUMBER : ");
                int five = int.Parse(Console.ReadLine());
                Console.WriteLine("The number is {0}", five);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Грешка в изпълнението на програмата! ->>  Очакваният тип данни е integer type.");
            }


            try
            {
                // Try to enter real local path to the file like C://My Pictures/... or similar
                // In other cases exception will be trown
                StreamReader sr = File.OpenText("data.txt");
                Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred when try to access the file C://My Documents/My Pictures/...! Please check the path to the file!");
            }

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}

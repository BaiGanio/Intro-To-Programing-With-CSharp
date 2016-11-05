using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string fiffer = "Fiffer Pig";
            string fidler = "Fiddler Pig";
            string practical = "Practical Pig";
            string bugi = "Буги Барабата";
            string china = "你吃了吗";

            int fifferSum = 0;
            int fidlerSum = 0;
            int practicalSum = 0;
            int bugiSum = 0;
            int chinaSum = 0;

            Console.WriteLine("{0} name length {1} ", fiffer, fiffer.Length);
            Console.WriteLine("{0} name length {1} ", fidler, fidler.Length);
            Console.WriteLine("{0} name length {1} ", practical, practical.Length);
            Console.WriteLine("{0} name length {1} ", bugi, bugi.Length);
            Console.WriteLine("{0} name length {1} ", china, china.Length);

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            for (int i = 0; i < fiffer.Length; i++)
            {
                fifferSum += (int)fiffer[i];
            }

            Console.WriteLine("Fiffer sum = " + fifferSum);

            for (int i = 0; i < fidler.Length; i++)
            {
                fidlerSum += (int)fidler[i];
            }

            Console.WriteLine("Fidler sum = " + fidlerSum);

            for (int i = 0; i < practical.Length; i++)
            {
                practicalSum += (int)practical[i];
            }

            Console.WriteLine("Practical sum = " + practicalSum);

            for (int i = 0; i < bugi.Length; i++)
            {
                bugiSum += (int)bugi[i];
            }

            Console.WriteLine("Bugi sum = " + bugiSum);

            for (int i = 0; i < china.Length; i++)
            {
                chinaSum += (int)china[i];
            }

            Console.WriteLine("China sum = " + chinaSum);

        }
    }
}

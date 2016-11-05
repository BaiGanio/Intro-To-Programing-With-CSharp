using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 30;
            // Change the value of the range in which the random numbers will be hang about 
            // and see a different behavior of the program result
            int randomRange = 1000007;
            Random rnd = new Random();
            double sum = 0;

            Console.WriteLine("Range = {0:N}", randomRange);

            int hitsTill300 = 0;
            int hitsTill600 = 0;
            int hitsTill999 = 0;

            for (int i = 0; i < days; i++)
            {
                int currentDayNumber = rnd.Next(0, randomRange);
                double sqrt = Math.Sqrt(currentDayNumber);
                Console.WriteLine(currentDayNumber + " => " + sqrt);

                if (sqrt >= 1 && sqrt <= 300)
                {
                    sum += sqrt * 5.1;
                    hitsTill300++;
                }
                if (sqrt >= 301 && sqrt <= 600)
                {
                    sum += sqrt * 10.098;
                    hitsTill600++;
                }
                if (sqrt >= 601 && sqrt <= 999)
                {
                    sum += sqrt * 100.00001;
                    hitsTill999++;
                }

            }

            Console.WriteLine("Sum is: {0:N4}", sum);
            Console.WriteLine("Hit in till 300 {0}", hitsTill300);
            Console.WriteLine("Hit in till 600 {0}", hitsTill600);
            Console.WriteLine("Hit in till 999 {0}", hitsTill999);


            if (sum > 1000000)
            {
                Console.WriteLine("This pigs are rich!");
            }


        }
    }
}

using System;

namespace HandyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctInputNumber = false;
            while (correctInputNumber == false)
            {
                try
                {
                    // 1. Take main number
                    Console.WriteLine("Enter number which will be used for some calculations: ");
                    int mainNumber = int.Parse(Console.ReadLine());

                    bool correctInputNumbersLenght = false;
                    while (correctInputNumbersLenght == false)
                    {
                        try
                        {
                            // 2. Take number(which will be the lenght) of the current input
                            Console.WriteLine("How much nubers do you want to enter: ");
                            int numbersInputLenght = int.Parse(Console.ReadLine());
                        }
                        catch (Exception exx)
                        {
                            Console.WriteLine(exx.Message);
                            correctInputNumbersLenght = false;
                        }
                        correctInputNumbersLenght = true;
                    }

                    correctInputNumber = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    correctInputNumber = false;
                }
                Console.WriteLine("-----------------------------------------------");
            }

           






            // 3. Store each entered number into data collection
            // 4. Do some calculation
            //     - a)
            //     - b)
            //int counter = 10;
            //Console.Write("Working");
            //while (counter > 0)
            //{
            //    Console.Write(".");
            //    Thread.Sleep(500);
            //    counter--;
            //}
            //Console.WriteLine();
            //Thread.Sleep(1000);
            //Console.WriteLine("Calculations are completed successfuly!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Showing the results: ");
            //Thread.Sleep(1000);
            //Console.ReadKey();
        }
    }
}

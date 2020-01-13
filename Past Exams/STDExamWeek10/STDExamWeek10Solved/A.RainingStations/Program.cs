using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.RainingStations
{
    class Program
    {
        // Declare and initialize a variable from type Random
        static Random rand = new Random();

        static void Main(string[] args)
        {
            /* Simple UI. Note that you can either do it like this or you can just
             type Console.WriteLine() 4 times. It doesn't matter. */
            Console.WriteLine("Choose a station:\n" +
                "1 --> Sofia station\n" +
                "2 --> Plovdiv station\n" +
                "3 --> Burgas station");
            
            /* Declare and initialize two variables: one will be a number corresponding
               to one of the options above and the other will check if the option is really a number.
               We do the check in a simple while loop with a TryParse method. */
            bool optionIsNumber = false;
            int option = 0;

            while (!optionIsNumber)
            {
                Console.Write("Enter your option here: ");
                optionIsNumber = int.TryParse(Console.ReadLine(), out option);
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("----------------\n" +
                        "Sofia Staion\n" +
                        "----------------");

                    /* Declare and initialize an array, in which the amount of rain will be stored.
                       Since we know there are 12 months in a year, we can hard code the length of the array. */
                    int[] sofiaArray = new int[12];

                    // Call the two methods for input and output
                    InputArray(sofiaArray);
                    OutputArray(sofiaArray);

                    /* Declare a variable which will store the average amount of
                       rain for a year. We will assign the value of the method 
                       AverageAmountOfRainingForAYear() to it and then display it. */
                    double averageRainInSofia = AverageAmountOfRainingForAYear(sofiaArray);
                    Console.WriteLine("The average amount of rain for a year in this station is: {0:F2} mm/m2",
                        averageRainInSofia);

                    // Display which months meet the required filter
                    PrintMonthsWithFilter(sofiaArray);

                    break;
                // The same algorithm goes for the next two stations (Plovdiv and Burgas).
                case 2:
                    Console.WriteLine("----------------\n" +
                        "Plovdiv Staion\n" +
                        "----------------");

                    int[] plovdivArray = new int[12];
                    InputArray(plovdivArray);
                    OutputArray(plovdivArray);
                    double averageRainInPlovdiv = AverageAmountOfRainingForAYear(plovdivArray);
                    Console.WriteLine("The average amount of rain for a year in this station is: {0:F2} mm/m2",
                        averageRainInPlovdiv);
                    PrintMonthsWithFilter(plovdivArray);

                    break;
                case 3:
                    Console.WriteLine("----------------\n" +
                        "Burgas Staion\n" +
                        "----------------");

                    int[] burgasArray = new int[12];
                    InputArray(burgasArray);
                    OutputArray(burgasArray);
                    double averageRainInBurgas = AverageAmountOfRainingForAYear(burgasArray);
                    Console.WriteLine("The average amount of rain for a year in this station is: {0:F2} mm/m2",
                        averageRainInBurgas);
                    PrintMonthsWithFilter(burgasArray);

                    break;
                // If the user types a number different from the options (1, 2 or 3), display an error.
                default:
                    Console.WriteLine("Incorrect number of station!");
                    break;
            }
        }

        /*It is good practice to put all other methods after the Main() method.

          We'll start off by making two simple methods: the first will assign
          random values of amount of rain for each month in the year in the given range.
          The second method will display those values. */
        static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // Using the rand variable, we assign random values for each month...
                arr[i] = rand.Next(0, 201);
            }
        }

        static void OutputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // ...and then display them in the console.
                Console.WriteLine("Raining in month " + (i + 1) + ": " + arr[i] + " mm/m2");
            }
        }

        /* This method will be a bit different than the others before. Rather than
           declaring it as void, we'll declare it as double, because we need it
           to return a value (the average amount of rain for a year) */
        static double AverageAmountOfRainingForAYear(int[] arr)
        {
            double totalAmountOfRainForAYear = 0;

            // Using a for loop, we'll add up every month's amount of rain in a single variable.
            for (int i = 0; i < arr.Length; i++)
            {
                totalAmountOfRainForAYear += arr[i];
            }

            // Then we'll return the average value of rain for the whole year
            return totalAmountOfRainForAYear / arr.Length;
        }

        /* The last method that we'll need to complete the task will be a filter method.
           In our case, it will check if the months meet a certain criteria. */
        static void PrintMonthsWithFilter(int[] arr)
        {
            /* Check if there are any months, which fulfill the cirteria and if
               there are, display them. */
            bool thereAreMonths = false;

            for (int i = 0; i < arr.Length; i++)
            {
                // This is the criteria
                if(arr[i] > 76 && arr[i] % 7 == 0)
                {
                    thereAreMonths = true;
                    Console.WriteLine("Month " + (i + 1) + " has amount of rain more than 76 mm/m2 and that amount can be divided by 7 without remainder.");                    
                    break;
                }
            }

            // If there aren't any months fulfilling the criteria, display a suitable message
            if (!thereAreMonths)
            {
                Console.WriteLine("There aren't any months with rain more than 76 mm/m2, which can be divided by 7 without remainder.");
            }
        }

        /*-------------------------BONUS/NOT REQUIRED----------------------------
         If you really want to work on the program's visual presentation, instead
         of displaying month 1, month 2 etc., you can create an enum with the
         name of each month of the year and then in the for loops cast i as variable of type Months.
         If you don't know what an enum is, you can always Google it and get familiar with it :) 
         Here is the change in the code:
        
         enum Months
         {
           January, February, March, April, May, June, July, August, September, October, November, December
         }

         static void OutputArray(int[] arr)
         {
           for (int i = 0; i < arr.Length; i++)
           {
               Console.WriteLine("Raining in month " + ((Months) i) + ": " + arr[i] + " mm/m2");
           }
         }
         */
    }
}

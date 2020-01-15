using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We change the console encoding to UTF-8 because we'll need to work
               with non-latin characters. If this statement is ommited, foreign
               characters (like cyrillic characters) will be displayed weirdly. */
            Console.OutputEncoding = Encoding.UTF8;

            // Declare and initialize the variables we need
            bool inputIsCorrect = false;
            bool weightIsCorrect = false;

            string userInput;
            string astronautName = "";

            int weight = 0;

            // Check if the input is correct
            while (!inputIsCorrect || !weightIsCorrect)
            {
                Console.WriteLine("Enter your name and your weight (separate them with a space):");
                userInput = Console.ReadLine();
                
                /* Check if the input contains only one space. If it doesn't,
                   skip the code after "continue". */
                if(!userInput.Contains(" "))
                {
                    Console.WriteLine("Incorrect data!");
                    continue;
                }
                else
                {
                    inputIsCorrect = true;
                }

                /* Get the values for the astronaut's name and weight from the inital
                   input by using the methods Substring() and IndexOf(). */
                astronautName = userInput.Substring(0, userInput.IndexOf(" "));
                weightIsCorrect = int.TryParse(userInput.Substring(userInput.IndexOf(" ")), out weight);
            }

            /* Store the calculated height and energy at impact in suitable variables and display
               whether or not the astronaut is a "Jupiter pancake". */
            int fallHeight = CalculateHeight(astronautName);
            double energy = EnergyAtImpact(weight, fallHeight);

            Console.WriteLine("Energy at impact: " + energy + " joules");

            if (energy < 1500000)
            {
                Console.WriteLine("The candidate is approved!");
            }
            else
            {
                Console.WriteLine("The candidate is a \"Jupiter pancake\"!"); // Here we use character escaping by using the \ symbol
            }
        }

        /* This method calculates and returns the fall height by adding up each characters
           value from the name of the the astronaut */
        static int CalculateHeight(string name)
        {
            int charSum = 0;

            foreach(char c in name)
            {
                charSum += c;
            }

            return charSum;
        }

        // This methods calculates and returns the energy at impact by the given formula
        static double EnergyAtImpact(int mass, int height)
        {
            const double jupiterGravity = 24.79;

            return mass * jupiterGravity * height;
        }
    }
}

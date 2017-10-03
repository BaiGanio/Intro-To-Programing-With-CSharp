using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightInSolarSystemPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kgs as measured on Earth: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter the code coresponding to the name of the desired planet:");
            Console.WriteLine("1: Mercury");
            Console.WriteLine("2: Venus");
            Console.WriteLine("3: Earth (You already know the answer)");
            Console.WriteLine("4: Mars");
            Console.WriteLine("5: Jupiter");
            Console.WriteLine("6: Saturn");
            Console.WriteLine("7: Uranus");
            Console.WriteLine("8: Neptune");
            Console.WriteLine("9: Pluto (YES I AM OLD FASHIONED I KNOW)");
            Console.WriteLine(new string('-', 30));
            int planet = int.Parse(Console.ReadLine());
            double gravitationalRatio = 0; // the gravity on earth is 9,807
            double weightOnPlanet = 0;

            switch (planet)
            {
                case 1:
                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Mercury", weightOnPlanet);
                    break;
                case 2:
                    gravitationalRatio = 0.9;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Venus", weightOnPlanet);
                    break;
                case 3:
                    gravitationalRatio = 1;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("Why did you even bother running the program. But still you weigh {0} kgs ", weightOnPlanet);
                    break;
                case 4:
                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Mars", weightOnPlanet);
                    break;
                case 5:
                    gravitationalRatio = 2.53;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Jupiter", weightOnPlanet);
                    break;
                case 6:
                    gravitationalRatio = 1.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Saturn", weightOnPlanet);
                    break;
                case 7:
                    gravitationalRatio = 0.89;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Uranus", weightOnPlanet);
                    break;
                case 8:
                    gravitationalRatio = 1.14;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Neptune", weightOnPlanet);
                    break;
                case 9:
                    gravitationalRatio = 0.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine("You weigh approximetly {0} kgs on Pluto", weightOnPlanet);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter a digit from 1 to 9.");
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightOnDifferentPlanets
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your weight in kgs as measured on Earth: ");
            double weight = double.Parse(Console.ReadLine());
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
            int planet = int.Parse(Console.ReadLine());
            double gravitationalRatio = 0; // the gravity on earth is 9,807
            double weightOnPlanet = 0;

            switch (planet)
            {
                case 1:
                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Mercury");
                    break;
                case 2:
                    gravitationalRatio = 0.9;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Venus");
                    break;
                case 3:
                    gravitationalRatio = 1;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"Why did you even bother running the program. But still you weigh {weightOnPlanet} kgs ");
                    break;
                case 4:
                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Mars");
                    break;
                case 5:
                    gravitationalRatio = 2.53;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Jupiter");
                    break;
                case 6:
                    gravitationalRatio = 1.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Saturn");
                    break;
                case 7:
                    gravitationalRatio = 0.89;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Uranus");
                    break;
                case 8:
                    gravitationalRatio = 1.14;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Neptune");
                    break;
                case 9:
                    gravitationalRatio = 0.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximetly {weightOnPlanet} kgs on Pluto");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter a digit from 1 to 9.");
                    break;
            }

        }
    }
}

using IntroCSharp.Common.Enums.StarTrek;
using IntroCSharp.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Collections.Helpers
{
    public static class ListExamplesHelper
    {
        public static void GetPlanetsExample()
        {
            Planet romulus = new Planet
            {
                Name = "Romulus",
                PlanetType = StarTrekClasification.R,
                Description = PlanetDescription.R
            };
            Planet capellaIV = new Planet
            {
                Name = "Capella IV",
                PlanetType = StarTrekClasification.C,
                Description = PlanetDescription.C
            };

            List<Planet> planets = new List<Planet> { romulus, capellaIV };

            foreach (var planet in planets)
            {
                Console.WriteLine("Planet name: {0}", planet.Name);
                Console.WriteLine("Planet type: {0}", GetPlanetType(planet.PlanetType));
                Console.WriteLine("Planet description: {0}", GetPlanetDescription(planet.Description));
            }
        }

        public static string GetPlanetDescription(PlanetDescription description)
        {
            switch (description)
            {
                case PlanetDescription.R:
                    return "The home planet of the Romulan people and the capital world of the Romulan Star Empire. Romulus shares its orbit with a binary companion Remus. It, alongside Remus, was destroyed by the Hobus Supernova.";
                case PlanetDescription.C:
                    return
                        "The home world of the advanced, yet still tribally governed, Capellan species. Dr. McCoy was stationed on the planet for several years and was familiar with the strict Capellan customs. An ailuroid quadruped whose specimens, possessed of the power to discharge lightning-like bolts of electrical energy powerful enough to kill a humanoid, all hated captivity so much that they always had to be killed within four days of capture, the Capellan power cat, was also described as inhabiting the planet.";
                default:
                    return "No data";
            }
        }
        public static string GetPlanetType(StarTrekClasification clasification)
        {
            switch (clasification)
            {
                case StarTrekClasification.C:
                    return
                        "Typically small, young planets whose class depends on their age and solidity of their cores.";
                case StarTrekClasification.R:
                    return "A rogue planetary body, which is one that does not orbit a star but drifts freely in space.";
                default:
                    return "No data!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.TravelingToTheSunWithTheSpeedOfSound
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The values of the constants in this task are not important.
               The algorithm is what matters. */
            const double speedOfSound = 1225.044; // in km/h
            const long distToSun = 149600000; // in km
            double timeNeeded = Math.Round(distToSun / speedOfSound); // in hours
            // Search in the Internet how to transform hours into years and days.
            double timeNeededInYears = Math.Floor(timeNeeded / 8760);
            double leftoverDays = Math.Floor(((timeNeeded / 8760) - timeNeededInYears) * 365);

            Console.WriteLine($"The time needed to travel from the Earth to the Sun is {timeNeeded} hours, or " +
                $"{timeNeededInYears} years and {leftoverDays} days.");
        }
    }
}

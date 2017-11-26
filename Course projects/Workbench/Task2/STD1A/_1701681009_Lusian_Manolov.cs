using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.STD1A
{
    public static class _1701681009_Lusian_Manolov
    {
        public static void VolumeOfTruncatedCone_Test1_7I()
        {
            const double pi = Math.PI;

            Console.Write("Enter R=");
            double bigRadius = double.Parse(Console.ReadLine());
            Console.Write("Enter r=");
            double littleRadius = double.Parse(Console.ReadLine());
            Console.Write("Enter H=");
            double coneHeight = double.Parse(Console.ReadLine());

            double volumeOfTrunkatedCone = (pi * coneHeight) * (Math.Pow(bigRadius, 2) + ((bigRadius * littleRadius) + Math.Pow(littleRadius, 2))) / 3;

            Console.WriteLine("V= {0:F2}", volumeOfTrunkatedCone);
        }
    }
}

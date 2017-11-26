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
            double R = double.Parse(Console.ReadLine());
            Console.Write("Enter r=");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Enter H=");
            double H = double.Parse(Console.ReadLine());

            double V = pi * H * (R * R + R * r + r * r) / 3;

            Console.WriteLine("V= {0:F2}", V);
        }
    }
}

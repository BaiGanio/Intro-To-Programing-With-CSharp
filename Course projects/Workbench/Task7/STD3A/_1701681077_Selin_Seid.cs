using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.STD3A
{
    public static class _1701681077_Selin_Seid
    {
        public static void Changing_Strings_Task7_362()
        {
            string s, y, x;
            Console.Write("Въведи S: ");
            s = Console.ReadLine();
            Console.Write("Въведи Y: ");
            y = Console.ReadLine();
            Console.Write("Въведи X: ");
            x = Console.ReadLine();
            Change(s, y, x);
        }
        static void Change(string s, string y, string x)
        {
            if (s.StartsWith(x) || s.EndsWith(x) || s.IndexOf(x) != -1)
                Console.WriteLine(s.Replace(x, y));
        }
    }
}

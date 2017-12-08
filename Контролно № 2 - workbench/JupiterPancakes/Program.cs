using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                using (StreamReader sr = new StreamReader("Candidates.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                   int ress= CalcultateHeight(line);
                    Console.WriteLine(ress);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
        public static int CalcultateHeight(string name)
        {
            int sum = 0;
           for (int i = 0; i <name.Length; i++)
            {
               sum += Convert.ToInt32(name[i]);
            }
            return sum;
        }
     
    }
}

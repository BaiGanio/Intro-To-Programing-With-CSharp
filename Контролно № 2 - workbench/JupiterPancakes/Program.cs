using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine(ConvertCustomIdToInt("afeccbae-8900-487f-b7f3-1ad60166aea7"));
        }

        public static int ConvertCustomIdToInt(string id)
        {
            MD5 md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(id));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(ivalue);
=======
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
>>>>>>> d6f026980b7bde07774a570ec560623aacfd4c5c
        }
     
    }
}

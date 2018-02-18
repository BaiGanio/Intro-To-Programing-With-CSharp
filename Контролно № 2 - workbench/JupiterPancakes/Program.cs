using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertCustomIdToInt("afeccbae-8900-487f-b7f3-1ad60166aea7"));
        }

        public static int ConvertCustomIdToInt(string id)
        {
            MD5 md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(id));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(ivalue);
        }
    }
}

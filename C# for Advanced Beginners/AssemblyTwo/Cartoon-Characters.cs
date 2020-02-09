using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    public class CartoonCharacters
    {
        public void SimpleMethod()
        {
            Rabbit  rabbit = new Rabbit();
            /* Accessible 'cuz this classes are in the same assembly */
            Console.WriteLine(rabbit.Name);
            Console.WriteLine(rabbit.NickName);
        }
    }
}

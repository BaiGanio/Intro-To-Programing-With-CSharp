

using System;
using System.Runtime.InteropServices;
using AssemblyTwo;

namespace AssemblyOne
{
    /*
     * To be able to see AssemblyTwo we need to add reference to the project
     */

    public class Class1 : Rabbit
    {
        Rabbit rabbit = new Rabbit();

        public void PrintYa()
        {
            /* Lead to compile tim error, 'cuz in AssemblyTwo 'Name' member of the Rabbit class is decorate like internal - so in this AssemblyOne is not visible */
            //rabbit.Name = "Daffy Duck";
            Console.WriteLine("XAXAXAXXA. Nothing intresting here!");
            Console.WriteLine("_--------_");

            /* Here like derived class we can see the protected internal member */
            Class1 c1 = new Class1();
            Console.WriteLine(c1.NickName);
        }
    }
}

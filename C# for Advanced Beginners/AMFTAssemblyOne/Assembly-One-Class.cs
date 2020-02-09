using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMFTAssemblyOne
{
    public class AssemblyOneClass
    {
        public void Print()
        {
            Console.WriteLine("Hello from AssemblyOneClass!");
           
            Console.WriteLine("This AssemblyOneInternalClass is visible only to the classes in AMFTAssemblyOne");
           
            AssemblyOneInternalClass aoic = new AssemblyOneInternalClass();
            aoic.Print();
            Console.WriteLine("-------------------------");
        }
    }

    /* This will be available only to the classes within this assembly */
    internal class AssemblyOneInternalClass
    {
        public void Print()
        {
            Console.WriteLine("Hello from AssemblyOneInternalClass!");
        }
    }

}

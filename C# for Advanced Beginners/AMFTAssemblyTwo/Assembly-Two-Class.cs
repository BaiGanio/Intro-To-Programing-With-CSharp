using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMFTAssemblyOne;

namespace AMFTAssemblyTwo
{
    /* Add reference to AMTFAssemblyOne */
    public class AssemblyTwoClass
    {
        public void TestCallingAMFTAssemblyOne()
        {
            Console.WriteLine("Hello from AssemblyTwoClass! we will print message from AssemblyOneClass!");
            AssemblyOneClass a1 = new AssemblyOneClass();
            a1.Print();

            /* AssemblyOneInternalClass is not visible due it's internal level */
        }
    }
}

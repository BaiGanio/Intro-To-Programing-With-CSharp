using AMFTAssemblyOne;
using AMFTAssemblyTwo;

namespace AccessModifiersForTypes
{
    /* Add reference to AMFTAssemblyOne and AMFTAssemblyTwo */
    class Program
    {
        static void Main()
        {
            AssemblyOneClass a1 = new AssemblyOneClass();
            a1.Print();

            AssemblyTwoClass a2 = new AssemblyTwoClass();
            a2.TestCallingAMFTAssemblyOne();
        }
    }
}

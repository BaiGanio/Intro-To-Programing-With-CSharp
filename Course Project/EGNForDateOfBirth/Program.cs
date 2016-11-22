using System;
using System.Text;
using ProjectHelpers;

namespace EGNForDateOfBirth
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            _365 solve365 = new _365();
            solve365.CallEGNDemo();
        }
    }
}

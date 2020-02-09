using System;

namespace Delegates
{
    /*
     * Delegates are from reference types.
     * They are a type safe function pointer.
     * Signature of the delegate should match signature of the method
     */
    class Program
    {
        static void Main()
        {
            /* We need to pass in the constructor the method we are pointing to */
            SayHiFunctionDelegate sh = new SayHiFunctionDelegate(SayHi);
            sh("This is real shit. The delegate invoke this.");
        }

        public static void SayHi(string word)
        {
            Console.WriteLine(word);
        }
    }

    public delegate void SayHiFunctionDelegate(string word);

}

/*
     * Delegates are from reference types.
     * They are a type safe function pointer.
     * Signature of the delegate should match signature of the method
     * A delegate will allow us to specify what the function we'll be calling looks like without having to specify which function to call.
     * The declaration for a delegate looks just like the declaration for a function, except that in this case,
     * we're declaring the signature of functions that this delegate can reference.
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
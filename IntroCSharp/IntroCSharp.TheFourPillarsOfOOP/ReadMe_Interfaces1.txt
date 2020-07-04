/*
    * Interfaces can have:
    * 1. Properties
    * 2. Methods
    * 3. Delegates
    * 4. Events
    * 5. Interfaces cannot have fields
    * They contain only declarations & there is no implementation -> there will be compile time error if we provide implementation for any interface member.
    * They are public by default & no need explicit access modifiers.
    * 
    * Classes provide multiple Interface inheritance
    */
    class Program
    {
        static void Main()  
        {
            Customer c1 = new Customer();
            c1.PrintSomething();
            c1.JangoZe();
        }
    }

    interface IShopper
    {
        /* Notice NO FIELDS */

        /* Notice NO IMPLEMENTATION */
        void PrintSomething();
    }

    interface I2
    {
        void JangoZe();
    }

    public class Customer : IShopper, I2
    {
        private string _fiki = "Fiki Kra4eto";

        public void JangoZe()
        {
            Console.WriteLine("{0}", _fiki);
        }
        public void PrintSomething()
        {
            Console.WriteLine("This is from Interface PrintSomething() method.");
        }
    }
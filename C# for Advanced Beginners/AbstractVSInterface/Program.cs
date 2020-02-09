using System;

namespace AbstractVSInterface
{
    class Program
    {
        static void Main()
        {
        }
    }

    /* Can inherit from interfaces & other abstract classes & have access modifiers */
    public abstract class Customer
    {
        private int ID;
        /* Can have method implementation */
        public void Print()
        {
            Console.WriteLine("Print that!");
        }
    }

    /* Can inherit only from interfaces & have not access modifiers */
    interface ICustomer
    {
        /* Interface cannot contain fields */

        /* Cannot have method implementation */
        void Print();
    }
}

using System;

namespace ExplicitInterfacesImplementation
{
    /*
     * When class inherits from two interfaces and both the interfaces have the same method...?
     * In this case we should use Explicit Interface Implementation: this mean that the interface member can no longer be accessed by class reference variable but only thru interface reference variable.
     */
    class Program : IOne, ITwo, IDefault
    {
        static void Main()
        {
            /* p is object reference variable */
            var p = new Program();
            ((IOne)p).PrintThat();
            ((ITwo)p).PrintThat();
            p.PrintThat();
        }
        /* When we use explicit interface implementation we are NOT allowed to use access modifiers & we need to use inteface name*/
        void IOne.PrintThat()
        {
            Console.WriteLine("IOne interface method.");
        }
        void ITwo.PrintThat()
        {
            Console.WriteLine("ITwo interface method.");
        }

        public void PrintThat()
        {
            Console.WriteLine("This is the IDefault implemented normally.");
        }
    }

    interface IOne
    {
        void PrintThat();
    }
    interface ITwo
    {
        void PrintThat();
    }
    interface IDefault
    {
        void PrintThat();
    }
}

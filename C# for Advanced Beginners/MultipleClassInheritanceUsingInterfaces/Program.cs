using System;

namespace MultipleClassInheritanceUsingInterfaces
{
    class Program
    {
        static void Main()
        {
            /* Now we will be in position to call the implemented methods from the two classes */
            var ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }

    class AB : IA, IB
    {
        /* Since class A & B already implemented the interfaces we can use this implementations provided by the methods */ 
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }

    }

    interface IA
    {
        void AMethod();
    }
    interface IB
    {
        void BMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("Hello from A.");
        }
    }
    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("Hello from B.");
        }
    }
}

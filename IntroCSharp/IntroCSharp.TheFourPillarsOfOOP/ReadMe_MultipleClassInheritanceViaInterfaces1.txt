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








namespace MultipleClassInheritanceProblems
{
    /* So called DIAMOND PROBLEM */
    class Program
    {
        static void Main()
        {
            /* Wich versions of the overwritten Print method should be invoked?  */
            //D d = new D();
            //d.Print();
        }
    }

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A implementation.");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B implementation.");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C implementation.");
        }
    }

    /* This will lead to compile time error */
    //class D : B, C
    //{
        
    //}
}
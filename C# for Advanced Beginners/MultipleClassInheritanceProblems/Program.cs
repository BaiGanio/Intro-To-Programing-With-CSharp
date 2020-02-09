using System;

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

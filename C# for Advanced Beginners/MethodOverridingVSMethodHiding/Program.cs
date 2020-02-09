using System;

namespace MethodOverridingVSMethodHiding
{
    /*
     * Base class reference variable can point to derived class object.
     * 
     * In method overriding a BaseClass reference variable is pointing to a child class object & will invoke the overriden method in the Child class.
     * 
     * In method hiding a BaseClass reference variable is pointing to a child class object & will invoke the hidden method in the Base class
     */
    class Program
    {
        static void Main()
        {
            BaseClass bc = new DerivedOverrideClass();
            bc.Print();
            Console.WriteLine("---------------------");
            BaseClass bc1 = new DerivedHidingClass();
            bc1.Print();
            Console.WriteLine("---------------------");
            /* If we want to hide the base class method we need reference variable not to be from base class type: */
            DerivedHidingClass dh = new DerivedHidingClass();
            dh.Print();

        }
    }

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("This is Base class method!");
        }
    }

    public class DerivedOverrideClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("This is Derived class method with overriding!");
        }
    }

    public class DerivedHidingClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("This is Derived class method with method hiding!");
        }
    }

}

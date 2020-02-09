using System;

namespace MethodHiding
{
    class Program
    {
        static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.PrintNameWithoutHide();
            fte.PrintName();
        }
    }

    public class Employee
    {
        private readonly string _firstName = "John";
        private readonly string _lastName = "Tri Bolta";
        private readonly string _email = "reza4kat@qko.bg";

        public void PrintNameWithoutHide()
        {
            Console.WriteLine("Name: {0} \nEmail: {1} without method hiding!", _firstName + " " + _lastName, _email);

        }

        public void PrintName()
        {
            Console.WriteLine("Name: {0} \nEmail: {1} with method hiding!", _firstName + " " + _lastName, _email);
        }

    }

    public class FullTimeEmployee : Employee
    {
        /* In case to hide base class member we use 'new' keyword in front of the method. */
        public new void PrintName()
        {
            //Console.WriteLine("The method in derived class is acting different now!");
            base.PrintName();
        }
    }

}

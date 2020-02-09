using System;

namespace Polymorphism
{
    /*
     * Polymorphism allows us to invoke the derived class method through base class variable at runtime.
     * In base class if method is declared virtual that's mean that in the derived class we can override the same method.
     * The 'virtual' keyword indicates that the method can be overridden in any derived class.
     */
    class Program
    {
        static void Main()
        {
            Employee[] employees = {new Employee(), new FullTimeEmployee(), new PartTimeEmployee(), new TemporaryEmployee()};
            foreach (var employee in employees)
            {
                employee.PrintInfo();
                employee.PrintCustomInfo();
                Console.WriteLine("---------------");
            }

        }
    }

    public class Employee
    {
        private const string Name = "Bugs Bunny";
        private const int Age = 23;

        public void PrintInfo()
        {
            Console.WriteLine("My name is {0} and I'm {1}", Name, Age);
        }

        /* This allows the derived classes to override the method by it's own preferences. */
        public virtual void PrintCustomInfo()
        {
            Console.WriteLine("My name is {0} and I'm {1} from virtual PrintCustomInfo()", Name, Age);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintCustomInfo()
        {
            Console.WriteLine("I'm FullTimeEmployee from PrintCustomInfo()");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintCustomInfo()
        {
            Console.WriteLine("I'm PartTimeEmployee from PrintCustomInfo()");
        }
    }

    public class TemporaryEmployee : Employee
    {
        
    }

}

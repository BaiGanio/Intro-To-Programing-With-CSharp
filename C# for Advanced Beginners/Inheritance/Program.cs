using System;

namespace Inheritance
{
    /* Move the common functionallity in base class which can be reuse across derived classes. That's mean that inheritance allows code reuse. 
       - C# supports only single class inheritance.
       - Base classes are automatically instantiated before derived classes.
       - Parent class constructor executes before Child class constructor. 
    */
    class Program
    {
        static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee("Boni", "Moni","Margo@mente.com");
            fte.PrintName();

            Console.WriteLine("--------------------------------");

            PartTimeEmployee pte = new PartTimeEmployee("John", "Rambo", "liza4a@liz.bliz");
            pte.PrintName();

            Console.WriteLine("--------------------------------");

            PartTimeEmployee pteFake = new PartTimeEmployee();
            pteFake.PrintName();

        }
    }

    public class Employee
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _email;

        public Employee()
            : this("No first name", "No last name", "No email")
        {
            
        }
        public Employee(string fName, string lName, string mail)
        {
            this._firstName = fName;
            this._lastName = lName;
            this._email = mail;
        }

        public void PrintName()
        {
            Console.WriteLine("Name: {0} \nEmail: {1}", _firstName + " " + _lastName, _email);
        }

    }

    public class FullTimeEmployee : Employee
    {
        private float _yearSalary;

        public FullTimeEmployee(string fName, string lName, string mail) 
            : base(fName, lName, mail)
        {
            this._yearSalary = 50000;
        }
    }

    public class PartTimeEmployee : Employee
    {
        private float hourlyRate;

        public PartTimeEmployee()
            : base()
        {
            
        }
        public PartTimeEmployee(string fName, string lName, string mail)
            : base(fName, lName, mail)
        {
            
        }

    }

}

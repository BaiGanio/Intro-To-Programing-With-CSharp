using System;
using System.Collections.Generic;

namespace Methods
{
    public class Employee
    {
        private readonly string _firstName = "John";
        private readonly string _lastName = "Tri Bolta";
        private readonly string _email = "reza4ka@kef.com";

        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void PrintNameWithoutHide()
        {
            Console.WriteLine("Name: {0} \nEmail: {1} without method hiding!", _firstName + " " + _lastName, _email);

        }

        public void PrintName()
        {
            Console.WriteLine("Name: {0} \nEmail: {1} with method hiding!", _firstName + " " + _lastName, _email);
        }















    }

}

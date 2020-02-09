using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesDemo
{
    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee {ID = 11, Name = "Bugsy", Salary = 5000, Experience = 7},
                new Employee {ID = 14, Name = "Mirko", Salary = 7000, Experience = 6},
                new Employee {ID = 10, Name = "Franki", Salary = 3000, Experience = 3},
                new Employee {ID = 11, Name = "Alice", Salary = 6000, Experience = 4}
            };

            //Employee.PromoteEmployee(empList);

            /* Using Lambda expressions save us a lot of code */
            //Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);

            /* Create instance of the delegate and pass an arguments */
            IsPromotable promo = new IsPromotable(Promo);
            Employee.PromoteEmployee(empList, promo);

        }

        public static bool Promo(Employee employee)
        {
            return employee.Experience >= 5;
        }
    }
    internal delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        /* This is bad 'cuz we hardcoded the logic in our method & it's not flexible*/
        public static void PromoteEmployee(List<Employee> employees )
        {
            foreach (var emp in employees)
            {
                if (emp.Experience >= 5)
                {
                    Console.WriteLine("{0} is PROMOTED!", emp.Name);
                }
            }
        }

        public static void PromoteEmployee(List<Employee> employees, IsPromotable isEligableToPromote)
        {
            foreach (var emp in employees)
            {
                if (isEligableToPromote(emp))
                {
                    Console.WriteLine("{0} is PROMOTED!", emp.Name);
                }
            }
        }


    }

}

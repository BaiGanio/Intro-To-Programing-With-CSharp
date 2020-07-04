using IntroCSharp.Common.Enums;
using IntroCSharp.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCSharp.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                So far we know simple data types like int, float, double ...
                But what if we want to have custom and more complex types? We use classes!
        
                !!!
                Class consist:
                1. Data/State - represented by fields;
                2. Behavior - represented by methods;         
            */

            // Demo1();


            /*
                Marking the class fields 'public' is a bad practice, 'cus we don't have control over what's get assigned and returned.
                So we need to encapsulate and protect fields.
                Programming languages that doesn't have properties use getter & setter methods.
             */

            // Demo2();


            /* Struct */
            // Demo3();

            /* Enum */
             // Demo4();

            /* Attributes */
            Demo5();

            /* Static And Instance Class Members */
            Demo6();
        }

        private static void Demo6()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Circle c1 = new Circle(5);
            double area = c1.CalculateArea();
            Console.WriteLine("c1 Area is {0}", area);

            Console.WriteLine("----------------------------------");
            /* Calling static method */
            Circle.SayHello();
        }

        private static void Demo5()
        {
            /* What if we want to pass 20 arguments? */
            int jo = Calculator.Add(20, 30);
            Console.WriteLine(jo);
            /* Lead to compile time error */
            //Calculator.Add(10, 15, 5);
            jo = Calculator.Add(new List<int> { 10, 20, 30 });
            Console.WriteLine(jo);
        }

        private static void Demo4()
        {
            int[] enumValues = (int[])Enum.GetValues(typeof(Gender));
            foreach (var enumValue in enumValues)
            {
                Console.WriteLine(enumValue);
            }

            string[] enumNames = Enum.GetNames(typeof(Gender));
            foreach (var enumName in enumNames)
            {
                Console.WriteLine(enumName);
            }

            Console.WriteLine();
            Console.WriteLine("============================");

            /* Changed Enums */
            short[] changedEnumValues = (short[])Enum.GetValues(typeof(GenderWithChangedUnderlayingDataTypeAndValues));
            foreach (var changedEnumValue in changedEnumValues)
            {
                Console.WriteLine("Now this is short -> " + changedEnumValue);
            }
            /* Names will be the same */
            string[] changedEnumNames = Enum.GetNames(typeof(GenderWithChangedUnderlayingDataTypeAndValues));
            foreach (var changedEnumName in changedEnumNames)
            {
                Console.WriteLine(changedEnumName);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            /* Since enums are strongly typed constants we need casting */
            int num = (int)Season.Autumn;
            Console.WriteLine(num);

            Customer[] cust =
            {
                new Customer { Name = "John", Gender = 1, Job = JobTitle.TestSubject},
                new Customer {Name = "Marcheto", Gender = 2, Job = JobTitle.Unknown},
                new Customer {Name = "It", Gender = 0, Job = JobTitle.Astronaut}
            };
            foreach (var customer in cust)
            {
                Console.WriteLine("Name is {0} & Gender is {1} & Job is {2}", customer.Name, GetGender(customer.Gender), GetJob(customer.Job));
            }
        }

        /// <summary>
        ///  Returns gender string value of the passed integer
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data!";
            }
        }

        public static string GetJob(JobTitle job)
        {
            switch (job)
            {
                case JobTitle.TestSubject:
                    return "This is test mouse";
                case JobTitle.Astronaut:
                    return "This is something new!.";
                case JobTitle.Unknown:
                    return "Most likely smug!";
                default:
                    return "Invalid data!";
            }
        }

        private static void Demo3()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Customer c1 = new Customer(99, "John Rambo");
            c1.PrintDetails();

            /*
             * Object initializer syntax 
                !!! Notice that c1 or c2 are not the Object itself. They are just a object reference variables wich are keeped in the Stack. Actual object this variables refers to is stored in the Heap.
             */
            Customer c2 = new Customer()
            {
                ID = 80,
                Name = "Daffy Duck"
            };
            c2.PrintDetails();

            Customer c3 = c2;
            c3.PrintDetails();

            c2.Name = "Ежко Бежко";
            c2.PrintDetails();

            /* Since Customer is struct there is no overwrite of the data. Change Customer to class to see the difference */
            c3.PrintDetails();
        }

        private static void Demo1()
        {
            Console.OutputEncoding = Encoding.UTF8;

            CustomApplicationUser defaultUser = new CustomApplicationUser();
            defaultUser.PrintUserData();

            Console.WriteLine("-------------------------------------------");

            CustomApplicationUser realUser = new CustomApplicationUser("Bugs Bunny", "123456");
            realUser.PrintUserData();
        }

        private static void Demo2()
        {
            Student student = new Student();
            student.SetId(100);
            Console.WriteLine("Student ID: {0}", student.GetId());
            //student.SetName(null);
            //student.SetName("Bugsy");
            Console.WriteLine("Student name: {0}", student.GetName());
            Console.WriteLine("Student mark is: {0}", student.GetPassMark());
        }
    }
}

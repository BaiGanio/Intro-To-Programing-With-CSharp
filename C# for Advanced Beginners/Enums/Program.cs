using System;

namespace Enums
{
    /*
     * Enums are strongly typed constants
     */
    class Program
    {
        private static void Main()
        {
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
    }


    enum JobTitle
    {
        Unknown,
        TestSubject,
        Astronaut
    }

    /*
     * If Gender is:
     * 0 - unknown
     * 1 - Male
     * 2 - Female
     */
    class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        public JobTitle Job { get; set; }
    }
}

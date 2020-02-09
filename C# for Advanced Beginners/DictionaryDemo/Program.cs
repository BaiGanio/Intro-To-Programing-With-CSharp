using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryDemo
{
    /*
     * Here we'll see few methods of Dictionary class:
     * - TryGetValue()
     * - Count() - find total count of items presented in the dictionary.
     * - Remove()
     * - Clear()
     * - Using LINQ extensions methods 
     * - Convert array into a dictionary - we need to specify what is the key for the dictionary & what is the value
     */
    class Program
    {
        static void Main(string[] args)
        {
            Student bugsy = new Student { ID = 101, Name = "Bugs Bunny", City = "California", Salary = 5000 };
            Student daffy = new Student { ID = 201, Name = "Daffy Duck", City = "New York", Salary = 6000 };
            Student taz = new Student { ID = 301, Name = "Tazmanian Devil", City = "Sidney", Salary = 4000 };
            Student lyuben = new Student { ID = 401, Name = "Lyuben Kikov", City = "Sidney", Salary = 4000 };

            Dictionary<int, Student> studentsDictionary = new Dictionary<int, Student>
            {
                { bugsy.ID, bugsy },
                { daffy.ID, daffy },
                { taz.ID, taz },
                {lyuben.ID, lyuben }
            };

            /* If we specify a key who doesn't exist there will be no exception. So stay cool :) */
            studentsDictionary.Remove(41);

            /* Print our students: */
            foreach (KeyValuePair<int, Student> student in studentsDictionary)
            {
                Console.WriteLine("ID = {0} & Name = {1} & City = {2} & Salary = {3}",
                    student.Value.ID, student.Value.Name, student.Value.City, student.Value.Salary);
            }
            Console.WriteLine("----------------------------------------------------------");

            /* To get a value wich is associated with specific key we use: */
            /* But this not protects us from KeyNotFoundException! */
            //Console.WriteLine(studentsDictionary[10].City);

            /* So if we are not sure if the dictionary contains specific key or key doesn't exist we
              * should use TryGetValue.
              * This method returns an output parameter with the value associated with the specific key.
              * Notice that return type of the method is 'bool'
              */
            Student stud;
            bool find = studentsDictionary.TryGetValue(1001, out stud);
            //bool find = studentsDictionary.TryGetValue(101, out stud);
            if (find)
            {
                Console.WriteLine("ID = {0}; Name = {1}; City = {2}", stud.ID, stud.Name, stud.City);
                Console.WriteLine("---------------------------------------------");
            }
            else
            {
                Console.WriteLine("Key is not found!");
                Console.WriteLine("--------------------------------------------------");
            }

            /* Count() method is presented in LINQ namespace so it is LINQ extension method & is used on dictionary object
             * So we can use some LINQ functionallity.
             */

            /* Regular approach represent in System.Collection.Generic: */
            Console.WriteLine("Total items in studentsDictionary: {0}", studentsDictionary.Count);

            Console.WriteLine("----------------------------------------------------------------------");

            /* Using LINQ extension*/
            Console.WriteLine("Total students with salary bigger than $4 000 : {0}", 
                studentsDictionary.Count(kvp => kvp.Value.Salary > 4000));

            Console.WriteLine("Total students where City start with 'S' : {0}",
                studentsDictionary.Count(kvp => kvp.Value.City.StartsWith("S")));
            Console.WriteLine("----------------------------------------------------------------------");

            /* Create array */
            Student[] studentsArray = {bugsy, daffy, taz, lyuben};

           Dictionary<int, Student> dict =  studentsArray.ToDictionary(studs => studs.ID, studs => studs);

            foreach (KeyValuePair<int, Student> student in dict)
            {
                Console.WriteLine("Key = {0}", student.Key);
                Student st = student.Value;
                Console.WriteLine("Name = {0} & City is {1}", st.Name, st.City);
            }




        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }

        public static void SayQ()
        {
            Console.WriteLine("Say Q!");
        }
    }
}

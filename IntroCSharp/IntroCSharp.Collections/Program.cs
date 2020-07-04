using IntroCSharp.Common.Enums;
using IntroCSharp.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroCSharp.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              * Dictionary is collection of (key, value) pairs.
              * When creating dictionary, we need to specify the type for key and value.
              * Keys in dictionary must be unique.
              */
            Demo1();

            /*
             * Here we'll see few methods of Dictionary class:
             * - TryGetValue()
             * - Count() - find total count of items presented in the dictionary.
             * - Remove()
             * - Clear()
             * - Using LINQ extensions methods 
             * - Convert array into a dictionary - we need to specify what is the key for the dictionary & what is the value
             */
            Demo2();

            /*
            * List is one of the generic collection classes present in System.Collection.Generic namespace.
            * There are several collection classes:
            * - Dictionary
            * - Stack
            * - Queue
            * - etc.
            * 
            * List can be use to create a collection of any type (int, string, Person, etc.).
            * Notice that they are strongly typed.
            * Object stored in a list can be accessed by index & unlike arrays, they can grow in size automatically.
            * List provides also methods to search, sort & manipulate lists.
            *  
            */
            Demo3();
        }

        private static void Demo3()
        {
            Rabbit peshko = new Rabbit { Name = "Peshko Bunny", Color = Color.Brown };
            Rabbit niki = new Rabbit { Name = "NikiBoy Bunny", Color = Color.White };
            Rabbit me4o = new Rabbit { Name = "Me4o Puh Bunny", Color = Color.Grey };

            Rabbit[] rabbits = new Rabbit[2];
            rabbits[0] = peshko;
            rabbits[1] = niki;
            /* 'me4o' is outside the boundries of the array. So there will be exception thrown. */
            //rabbits[2] = me4o;

            Console.WriteLine("Array:");
            foreach (Rabbit rabbit in rabbits)
            {
                Console.WriteLine("Name = {0} & Color = {1}", rabbit.Name, rabbit.Color);
            }

            Console.WriteLine("----------------------------------------------------");

            List<Rabbit> rabbitsList = new List<Rabbit>(2);
            rabbitsList.Add(peshko);
            rabbitsList.Add(niki);
            rabbitsList.Add(me4o);

            /* We can insert data in the list at specific location */
            rabbitsList.Insert(0, me4o);
            Console.WriteLine("List:");
            foreach (Rabbit rabbit in rabbitsList)
            {
                Console.WriteLine("Name = {0} & Color = {1}", rabbit.Name, rabbit.Color);
            }

            /* We can find the index of the specific item in the list. By default we take the first element that matches */
            Console.WriteLine(rabbitsList.IndexOf(me4o));

            /* Start searching from specific position */
            Console.WriteLine(rabbitsList.IndexOf(me4o, 1));

            /* Another overloaded version is to search from specific posiotion a certain number of times */
            /* 4 will be outside the range & will throw exception */
            Console.WriteLine(rabbitsList.IndexOf(me4o, 1, 3));
        }

        private static void Demo2()
        {
            Student bugsy = new Student { Id = 101, /*Name = "Bugs Bunny",*/ City = "California", Salary = 5000 };
            Student daffy = new Student { Id = 201, /*Name = "Daffy Duck",*/ City = "New York", Salary = 6000 };
            Student taz = new Student { Id = 301, /*Name = "Tazmanian Devil",*/ City = "Sidney", Salary = 4000 };
            Student lyuben = new Student { Id = 401, /*Name = "Lyuben Kikov",*/ City = "Sidney", Salary = 4000 };

            Dictionary<int, Student> studentsDictionary = new Dictionary<int, Student>
            {
                { bugsy.Id, bugsy },
                { daffy.Id, daffy },
                { taz.Id, taz },
                {lyuben.Id, lyuben }
            };

            /* If we specify a key who doesn't exist there will be no exception. So stay cool :) */
            studentsDictionary.Remove(41);

            /* Print our students: */
            foreach (KeyValuePair<int, Student> student in studentsDictionary)
            {
                Console.WriteLine("ID = {0} & Name = {1} & City = {2} & Salary = {3}",
                    student.Value.Id, student.Value.University, student.Value.City, student.Value.Salary);
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
                Console.WriteLine("ID = {0}; Name = {1}; City = {2}", stud.Id, stud.Name, stud.City);
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
            Student[] studentsArray = { bugsy, daffy, taz, lyuben };

            Dictionary<int, Student> dict = studentsArray.ToDictionary(studs => studs.Id, studs => studs);

            foreach (KeyValuePair<int, Student> student in dict)
            {
                Console.WriteLine("Key = {0}", student.Key);
                Student st = student.Value;
                Console.WriteLine("Name = {0} & City is {1}", st.Name, st.City);
            }
        }

        private static void Demo1()
        {
            CartoonCharacter ch1 = new CartoonCharacter { Id = 100, Name = "Bugsy", Age = 20 };
            CartoonCharacter ch2 = new CartoonCharacter { Id = 101, Name = "Daffy", Age = 200 };
            CartoonCharacter ch3 = new CartoonCharacter { Id = 01, Name = "TAZ", Age = 5 };

            /* We need to specify the datatype for the Key & Value*/
            Dictionary<int, CartoonCharacter> cartCharDict = new Dictionary<int, CartoonCharacter>
            {
                {ch1.Id, ch1},
                {ch2.Id, ch2},
                {ch3.Id, ch3}
            };
            if (!cartCharDict.ContainsKey(500))
            {
                cartCharDict.Add(500, new CartoonCharacter { Id = 500, Name = "Franki", Age = 69 });
            }

            foreach (var cartoonCharacter in cartCharDict)
            {
                Console.WriteLine("Key is: {0}; & the values are: \ncartoonCharacter.Value.ID = {1} \ncartoonCharacter.Value.Name = {2} \ncartoonCharacter.Value.Age = {3}", cartoonCharacter.Key, cartoonCharacter.Value.Id, cartoonCharacter.Value.Name, cartoonCharacter.Value.Age);
                Console.WriteLine("----------------------------------------------");
            }

            /* OR */

            foreach (CartoonCharacter cartoonCharacter in cartCharDict.Values)
            {
                Console.WriteLine("ID = {0}; Name = {1}; Age ={2}", cartoonCharacter.Id, cartoonCharacter.Name, cartoonCharacter.Age);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}

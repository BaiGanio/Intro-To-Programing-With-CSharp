using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroCSharp.LINQ
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}; Age: {Age}; Email: {Mail}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
            {
                new User() { Name = "John Doe", Mail = "john@doe.com", Age = 42 },
                new User() { Name = "Jane Doe", Mail = "jane@doe.com", Age = 34 },
                new User() { Name = "Joe Doe", Mail = "joe@doe.com", Age = 8 },
                new User() { Name = "Another Doe", Mail = "another@doe.com", Age = 15 },
            };
            List<string> names = listOfUsers.Select(user => user.Name).ToList();

            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine("------------------------------------------------------------");
            // Method syntax
            var simpleUsers =
                listOfUsers
                .Select(user =>
                    new
                    {
                        user.Name,
                        user.Age,
                        NameAge = $"{user.Name} - {user.Age}"
                    });

            foreach (var user in simpleUsers)
                Console.WriteLine(user);
            Console.WriteLine("------------------------------------------------------------");
            // Query syntax
            var simpleUsersQ = (from user in listOfUsers
                                select new
                                {
                                    user.Name,
                                    user.Age,
                                    user.Mail
                                }).ToList();

            foreach (var user in simpleUsersQ)
                Console.WriteLine(user);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}

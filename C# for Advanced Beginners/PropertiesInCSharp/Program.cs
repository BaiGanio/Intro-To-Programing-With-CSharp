using System;

namespace PropertiesInCSharp
{
    class Program
    {
        static void Main()
        {
            Student student = new Student {City = "New York", University = "Monster University"};
            Console.WriteLine(student);
        }
    }

    public class Student
    {
        /*
         * Auto-implemented properties reduce the amount of code.
         * When we use auto-implemented properties, the compiler creates a private, anonymous fields that can be accessed through the property's get & set accessors.
         */
        public string City { get; set; }
        public string University { get; set; }
        public override string ToString()
        {
            string output = String.Format("Someone from {0} study in {1}", City, University);
            return output;
        }
    }

}

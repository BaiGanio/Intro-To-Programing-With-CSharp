using System;

namespace OverrideToStringMethod
{
    class Program
    {
        static void Main()
        {
            Student st = new Student {ID = 15, Name = "Tazmanian Devil", University = "Australia University"};

            /* The default implementation of ToString() gives us nothing more but the TYPE name */
            Console.WriteLine(st);


        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string University { get; set; }

        public override string ToString()
        {
            /* This will print the complete class name */
            //return base.ToString();

            /* This will print the complete meaningful representation of the class */
            string output = String.Format("{0}, {1}, {2}", this.ID, this.Name, this.University);
            return output;
        }
    }

}

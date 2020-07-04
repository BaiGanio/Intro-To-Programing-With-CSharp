using System;

namespace OverrideEqualsMethod
{
    class Program
    {
        static void Main()
        {
            const int i = 10;
            const int j = 12;

            /* There is few ways to check for equality */
            Console.WriteLine(i == j);

            /* Equals() is coming from System.Object */
            Console.WriteLine(i.Equals(j));

            /* Since underlying value of Enums is integer we can compare them*/
            const Direction d1 = Direction.East;
            const Direction d2 = Direction.South;

            Console.WriteLine(d1.Equals(d2));

            Console.WriteLine("------------------------------------------");

            Student st1 = new Student { ID = 15, Name = "Tazmanian Devil", University = "Australia University" };
            Student st2 = new Student { ID = 10, Name = "Daffy Duck", University = "Plovdiv University" };

            Console.WriteLine(st1.Equals(st2));

            Console.WriteLine("-----------------------------");

            /* Since the class is from reference type the two reference variables st3 & st1
             * are going to point to the same address in the memory
             */
            Student st3 = st1;
            Console.WriteLine(st1.Equals(st3));

            /* Here even with the same values st3 is pointing to different address in the memomry. So equality is false 'cuz' st1 & st3 are pointing to different memory locations */
            st3 = new Student { ID = 15, Name = "Tazmanian Devil", University = "Australia University" };

            Console.WriteLine(st1.Equals(st3));

            /* The problem here comes from the default implementation from the base class, 
             * 'cuz default implementation doesn't know wich properties to check for equality.
             * This forces us to override Equals() method.
             */


        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string University { get; set; }

        /* Here we override the Equals() method */
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Student))
            {
                return false;
            }

            return 
                this.ID == ((Student)obj).ID 
                && 
                this.Name == ((Student)obj).Name 
                &&
                this.University == ((Student)obj).University;

        }

        /* If we override Equals() it's recommended to override and GetHashCode to secure the uniqness 
         of the GetHashCode.
         */

        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Name.GetHashCode() ^ this.University.GetHashCode();
        }
    }

    enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

}

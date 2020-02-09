using System;
using System.Dynamic;

namespace WhyProperties
{
    /*
     * Marking the class fields 'public' is a bad practice, 'cus we don't have control over what's get assigned and returned.
     * So we need to encapsulate and protect fields.
     * Programming languages that doesn't have properties use getter & setter methods.
     */
    class Program
    {
        static void Main()
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

    public class Student
    {
        /*
         * Requirements:
         * 1. ID should always be non negative number.
         * 2. Name can't be set to NULL.
         * 3. If Student name is missing "No Name" should be returned.
         * 4. PassMark should be read only
         */
        private int ID;
        private string Name;
        private int PassMark = 2;

        /* There is few ways: */
        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student ID cannot be negative!");
            }
            this.ID = id;
        }
        public int GetId()
        {
            return this.ID;
        }

        public void SetName(string name)
        {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name cannot be null or empty!");
                }
                this.Name = name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(Name) ? "No Name" : this.Name;
        }

        /* To make PassMark 'read only' we need only get method */
        public int GetPassMark()
        {
            return this.PassMark;
        }
    }

}

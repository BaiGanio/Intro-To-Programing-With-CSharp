using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Models
{
    public class Student
    {
        /*
         * Requirements:
         * 1. ID should always be non negative number.
         * 2. Name can't be set to NULL.
         * 3. If Student name is missing "No Name" should be returned.
         * 4. PassMark should be read only
         */
        private int _id;
        private string _name;
        private int _passMark = 2;

        /* There is few ways: */
        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student ID cannot be negative!");
            }
            _id = id;
        }
        public int GetId()
        {
            return _id;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty!");
            }
            Name = name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(Name) ? "No Name" : this.Name;
        }

        /* To make PassMark 'read only' we need only get method */
        public int GetPassMark()
        {
            return _passMark;
        }


        /*
         * Auto-implemented properties reduce the amount of code.
         * When we use auto-implemented properties, the compiler creates a private, anonymous fields that can be accessed through the property's get & set accessors.
         */
        public int Id { get; set; }
        public string City { get; set; }
        public string University { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }

        public static void SayQ()
        {
            Console.WriteLine("Say Q!");
        }
        public override string ToString()
        {
            string output = String.Format("Someone from {0} study in {1}", City, University);
            return output;
        }
    }
}

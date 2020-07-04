using IntroCSharp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Models
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
            Job = JobTitle.Astronaut;
            Gender = 1;
        }

        public int ID { get { return this._id; } set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }
        public int Gender { get; set; }
        public JobTitle Job { get; set; }
        public void PrintDetails()
        {
            Console.WriteLine("Customer {0} have ID: {1}", this._name, this._id);
        }

    }
}

using System;
using System.Text;

namespace Struct
{
    /*
     * Structs can have:
     * 1. Private fields
     * 2. Public properties
     * 3. Constructors
     * 4. Methods
     * 
     * Struct is a value type - they are stored in the Stack.
     * Class is a reference  type - stored in the Heap.
     * 
     * Value types hold their value in memory where they are declared & are destroyd immediately after the scope is lost.
     * Reference types hold a reference to an object in memory & after the scope is lost only the reference variable is destroyed. The Object is later destroyed by the garbage collector.
     * 
     * Struct in .NET are int(System.Int32), double(System.Double)
     * 
     * If we use 'sealed' keyword we cannot be able to use the sealed class like a base class. 
     * Struct are sealed types, so classes & structs cannot inherit from another struct.
     */
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Customer c1 = new Customer(99, "John Rambo");
            c1.PrintDetails();

            /*
             * Object initializer syntax 
                !!! Notice that c1 or c2 are not the Object itself. They are just a object reference variables wich are keeped in the Stack. Actual object this variables refers to is stored in the Heap.
             */
            Customer c2 = new Customer()
            {
                ID = 80,
                Name = "Daffy Duck"
            };
            c2.PrintDetails();

            Customer c3 = c2;
            c3.PrintDetails();

            c2.Name = "Ежко Бежко";
            c2.PrintDetails();

            /* Since Customer is struct there is no overwrite of the data. Change Customer to class to see the difference */
            c3.PrintDetails();

        }
    }

    public struct Customer
    {
        private int _id;
        private string _name;

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public int ID { get { return this._id; } set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }

        public void PrintDetails()
        {
            Console.WriteLine("Customer {0} have ID: {1}", this._name, this._id);
        }

    }

}

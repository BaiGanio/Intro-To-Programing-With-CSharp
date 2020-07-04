using System;

namespace IntroCSharp.AccessModifiers
{
    class Program
    {
        static void Main()
        {
            Customer c1 = new Customer();
            /* This lead to compile time error */
            // c1._id;

            CorporateCustomer cc1 = new CorporateCustomer();
            cc1.PrintName();
        }
    }

    class CorporateCustomer : Customer
    {
        public void PrintName()
        {
            /* We can access the base class member by two ways */
            base.Name = "OXOXOX";
            Console.WriteLine("Name is " + base.Name);

            Console.WriteLine("============================");

            CorporateCustomer cc1 = new CorporateCustomer { Name = "Ala bala portokala" };
            Console.WriteLine(cc1.Name);

        }
    }
    class Customer
    {
        /* It's not available outside the class */
        private int _id;

        /* This protected member will be available in derived classes */
        protected string Name;

        public int ID { get { return this._id; } set { this._id = value; } }
    }
}

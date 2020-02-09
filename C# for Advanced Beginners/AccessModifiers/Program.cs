using System;

namespace AccessModifiers
{
    /*
     * There are 5 different access modifiers in C#
     *  MODIFIER     ACCESSIBILITY:
     * 1. Private - only in the containing class. Default for TYPE MEMBERS
     * 2. Protected - within the containing types & derived types
     * 3. Internal - anywhere within the containing assembly. Default for TYPES
     * 4. Protected Internal - anywhere within the containing assembly & within derived class in any other assembly
     * 5. Public - anywhere, no restrictions
     */
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

            CorporateCustomer cc1 = new CorporateCustomer {Name = "Ala bala portokala"};
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

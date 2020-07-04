 /* Can inherit from interfaces & other abstract classes & have access modifiers */
    public abstract class Customer
    {
        private int ID;
        /* Can have method implementation */
        public void Print()
        {
            Console.WriteLine("Print that!");
        }
    }

    /* Can inherit only from interfaces & have not access modifiers */
    interface ICustomer
    {
        /* Interface cannot contain fields */

        /* Cannot have method implementation */
        void Print();
    }

                    /*
     * Abstract classes are incomplete.
     * Abstract methods cannot have implementation.
     * We cannot have instance of abstract class.
     * They should be used only as base class.
     * Abstract class may contain abstract members (methods, properties, indexers & events), but not mandatory.
     */

                                             class Program : John
    {
        public override void SaySome()
        {
            Console.WriteLine("This is from abstract class Customer");
        }

        public override void SaySomeJohn()
        {
            Console.WriteLine("This is from abstract class John");
        }

        static void Main()
        {
            Program p = new Program();
            p.SaySome();
            // or
            John c = new Program();
            c.SaySomeJohn();

        }
    }

    public abstract class Customer
    {
        public abstract void SaySome();
    }

    /* If we don't want our class to provide implementation for all the abstract members inherited from the abstract class, the we shoul mark this class as abstract */

    public abstract class John : Customer
    {
        public abstract void SaySomeJohn();
    }
namespace Methods
{
    public class FullTimeEmployee : Employee
    {
        /* In case to hide base class member we use 'new' keyword in front of the method. */
        public new void PrintName()
        {
            //Console.WriteLine("The method in derived class is acting different now!");
            base.PrintName();
        }
    }

}

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace StaticAndInstanceClassMembers
{
    /*
     *  Class members = fields, methods, properties, events, indexers, constructors.
     *  With the 'static' keyword in method signature there is no need to create instance of the class to invoke the method.
     */
     
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Circle c1 = new Circle(5);
            double area = c1.CalculateArea();
            Console.WriteLine("c1 Area is {0}", area);

            Console.WriteLine("----------------------------------");
            /* Calling static method */
            Circle.SayHello();

        }
    }

    class Circle
    {
        /* Pi is already initialize & it's constant 'cuz there is no matter is only 1 circle or 100. But notice that we will have a 100 instances of the Pi => for each circle will be initialize a variable with that value. This will cause memory leaks. */
        private const float Pi = 3.141F;
        private readonly int _radius;
        /* When we use 'static' keyword we initialize the class member only once and it value is shared from all instances. No memory leak. */
        private static string _name;

        /* Static constructor is used to initialize static fields in a class. They are called only once no matter how many instances you create & before instance constructors. */
        static Circle()
        {
            _name = "Буги Барабата";
        }
        /* Instance constructor */
        public Circle(int radius)
        {
            this._radius = radius;
        }

        /* Static methods can be invoke only by the name of the class who holds them. */
        public static void SayHello()
        {
            Console.WriteLine("Hello from {0}", Pi);
        }
        public double CalculateArea()
        {
            double result = Math.Pow(this._radius, 2) * Pi;
            return result;
        }
    }

}

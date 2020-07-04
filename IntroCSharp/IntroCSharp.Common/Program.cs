using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodHiding(); // 1
            InstancedAndStaticMethods(); // 2
            
        }

        /// <summary>
        /// Without 'static' keyword our methods are so called instanced methods, 'cus we need to create instance of the class who holds the method
        /// </summary>
        private static void InstancedAndStaticMethods()
        {
            double number;

            /* Instanced method */
            Program p = new Program();
            p.EvenNumbers();
            p.EvenNumbers(12);
            number = p.MultiplyNumbers();
            Console.WriteLine(number);

            /* Static methods */
            OddNumbers();
            number = MultiplyNumbers(12);
            Console.WriteLine(number);
        }

        private static void MethodHiding()
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.PrintNameWithoutHide();
            fte.PrintName();
        }

        public void EvenNumbers()
        {
            int start = 0;
            while (start < 20)
            {
                Console.Write(start + " ");
                start += 2;
            }
            Console.WriteLine();
            Console.WriteLine("###############");
        }
        public void EvenNumbers(int target)
        {
            int start = 0;
            while (start < target)
            {
                Console.Write(start + " ");
                start += 2;
            }
            Console.WriteLine();
            Console.WriteLine("###############");
        }
        public double MultiplyNumbers()
        {
            return Math.Pow(5, 2);
        }
        public static void OddNumbers()
        {
            int start = 0;
            while (start < 20)
            {
                if (start % 2 != 0)
                {
                    Console.Write(start + " ");
                }
                start++;
            }
            Console.WriteLine();
            Console.WriteLine("###############");
        }
        public static double MultiplyNumbers(int number)
        {
            return Math.Pow(number, 2);
        }
    }
}

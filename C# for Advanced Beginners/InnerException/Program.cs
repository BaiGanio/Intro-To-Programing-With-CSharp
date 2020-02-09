using System;
using System.IO;

namespace InnerException
{
    /*
     * Always check if inner exception is not null before accessing any property of the inner exception object, else - we may get Null Reference Exception
     * To get the type of InnerException we use GetType() method
     */
    class Program
    {
        static void Main()
        {
            const string path = @"C:\Users\Republic Of Gamers\Desktop\Log.txt";
            try
            {
                try
                {
                    Console.Write("First number: ");
                    int fN = int.Parse(Console.ReadLine());
                    Console.Write("Second number: ");
                    int sN = int.Parse(Console.ReadLine());

                    int result = fN/sN;
                    Console.WriteLine("Result is: " + result);
                }
                catch (Exception ex)
                {
                    /* Log the exception */
                    if (File.Exists(path))
                    {
                        StreamWriter writer = new StreamWriter(path);
                        writer.Write(ex.GetType().Name);
                        writer.WriteLine();
                        writer.Write(ex.Message);
                        writer.Close();
                        Console.WriteLine("There is a problem. Try again later!");
                    }
                    else
                    {
                        /* Be aware to pass 'ex' to the constructor when we want to throw one. Otherwise innerexception will be null */
                        throw new FileNotFoundException(path + " is not found!");
                        //throw new FileNotFoundException(path + " is not found!", ex);
                    }

                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Current exception: {0}", ex1.GetType().Name);
                Console.WriteLine("Inner exception: {0}", ex1.InnerException.GetType().Name);
                /* If we are not sure is inner exception we should check for null */
                if (ex1.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", ex1.InnerException.GetType().Name);
                }
            }
        }
    }
}

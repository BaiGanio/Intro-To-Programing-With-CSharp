using IntroCSharp.Common.Helpers;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
/*
 * If we try to open a file, which doesn't exist, the code responsible for opening the file will detect this & will throw an exception with proper message
 */
/*
 * Showing unhandled exception is bad practice, 'cuz exceptions contain information that can be use for hacking the application.
 * Exception provide us with valuable information:
 * 1. Message: describes current exception.
 * 2. Stack Trace: provides the call stack to the line number int the method where exception occured.
 */
namespace IntroCSharp.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            Demo2_CustomException();
            Demo3_InnerException();

            Console.OutputEncoding = Encoding.UTF8;
            // Original File Name
            ////string wrongFileName = "../../../Files/text-file.txt";
            //string wrongFileName = "../../../SomeTestDataDemo.txt";
            //FileReader.PrintSingleLine(wrongFileName);



            /* Original File Name */
            //string wrongFileName = "../../../Files/text-file.txt";

            /* This will throw FileNotFoundException */
            //string wrongFileName = "../../../Files/SomeTestDataDemo.txt";

            /* This will throw DirectoryNotFoundException */
            string wrongFileName = "../../../Joshya/text-file.txt";

            FileReader.PrintAllLines(wrongFileName);

            ///////////////////////////////////
            ///

            /* Original File Name */
            //string wrongFileName = "../../../Files/text-file.txt";

            /* This will throw FileNotFoundException */
            // string wrongFileName = "../../../Files/SomeTestDataDemo.txt";

            /* If the file is deleted or renamed there will be exception thrown into the console */
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(wrongFileName);
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                /* This sensitive info will be not shown to the user */
                Console.WriteLine(fnfe.Message);
                Console.WriteLine("----------------------------");
                Console.WriteLine(fnfe.StackTrace);
                Console.WriteLine("--------------------------------");
                /* Show message to the user */
                Console.WriteLine("Check if {0} exist", fnfe.FileName);
                Console.WriteLine("----------------------------------------");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                Console.WriteLine("Stream CLOSED!");
                Console.WriteLine("END OF PROGRAM");
            }
        }

        private static void Demo3_InnerException()
        {
            const string path = @"C:\Users\Republic Of Gamers\Desktop\Log.txt";
           
                try
                {
                    Console.Write("First number: ");
                    int fN = int.Parse(Console.ReadLine());
                    Console.Write("Second number: ");
                    int sN = int.Parse(Console.ReadLine());

                    int result = fN / sN;
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
        private static void Demo2_CustomException()
        {
            //throw new FileNotFoundException();
            try
            {
                throw new AlreadyLoggedException("This user is logged. No duplicate sessions allowed.");
            }
            catch (AlreadyLoggedException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        /* This will allow us to use our custom exception class to work across application domains */
        [Serializable]
        /* Use descriptive name */
        public class AlreadyLoggedException : Exception
        {
            /* This is simple constructor overloading */
            public AlreadyLoggedException()
                : base()
            {

            }
            public AlreadyLoggedException(string message)
                : base(message)
            {
            }

            /* It is not possible for the custom exceptions to track the original exceptions. So we need to provide overloaded version of base exception constructor */
            public AlreadyLoggedException(string message, Exception innerException)
                : base(message, innerException)
            {

            }

            public AlreadyLoggedException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {

            }
        }

        private static void Demo1()
        {
            StreamReader reader = null;
            /* If the file is deleted or renamed there will be exception thrown into the console */
            try
            {
                reader = new StreamReader(@"C:\Users\Republic Of Gamers\Desktop\Helpfull Links100.txt");
                Console.WriteLine(reader.ReadToEnd());

            }
            /* This will lead to compile time error 'cuz most common base exception should be placed in the bottom  */
            //catch (Exception ex)
            //{

            //}
            catch (FileNotFoundException ex)
            {
                /* This sensitive info will be not shown to the user */
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------------------------");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("--------------------------------");
                /* Show message to the user */
                Console.WriteLine("Check if {0} exist", ex.FileName);
                Console.WriteLine("----------------------------------------");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                Console.WriteLine("Stream closed!");
            }
        }
    }
}

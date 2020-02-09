using System;
using System.IO;

namespace ExceptionHandling
{
    /*
     * Showing unhandled exception is bad practice, 'cuz exceptions contain information that can be use for hacking the application.
     * Exception provide us with valuable information:
     * 1. Message: describes current exception.
     * 2. Stack Trace: provides the call stack to the line number int the method where exception occured.
     */
    class Program
    {
        static void Main()
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

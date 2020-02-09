using System;
using System.IO;
using System.Runtime.Serialization;

namespace CustomException
{
    /*
     * We need custom excepions when none of the already existing .NET exceptons adequately describes the problem.
     * Scenario:
     * 1. We have .NET web application.
     * 2. The app should allow the user to have only one logged session.
     * 3. If user is logged and try to log in again from another browser window - the app should throw an error stating "This user is logged."
     */
    class Program
    {
        static void Main()
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

}

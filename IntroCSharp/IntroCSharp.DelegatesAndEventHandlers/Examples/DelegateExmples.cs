using IntroCSharp.Common.Models;
using IntroCSharp.DelegatesAndEventHandlers.Models;
using System;
using System.Diagnostics;

namespace IntroCSharp.DelegatesAndEventHandlers.Examples
{
    public static class DelegateExmples
    {
        // Declaration
        public delegate void BasicDemoDelegate();

        public static void DoExamples()
        {
            // 1. Simple Delegate With No Return Type
            //Demo1();

            // 2. delegate that takes a single string parameter and has no return type
            //Demo2();

            // 3. the Logger( ) function merely writes the string out. 
            // A different function might want to log the information to a file, but to do this, the function needs to know what file to write the information to
            //Demo3();

            // 5. Multicats delegates
            Demo4();
        }

        private static void Demo4()
        {
            FileLogger fl = new FileLogger($"../../../process-in-Demo4-{DateTime.Now.Ticks}.log");

            SimpleClass myClass = new SimpleClass();

            // Crate an instance of the delegate, pointing to the Logger()
            // function on the fl instance of a FileLogger.
            SimpleClass.LogHandler myLogger = null;
            myLogger += new SimpleClass.LogHandler(Logger);
            myLogger += new SimpleClass.LogHandler(fl.Logger);

            myClass.Process(myLogger);
            fl.Close();
        }

        private static void Demo3()
        {
            FileLogger fl = new FileLogger($"../../../process-in-Demo3-{DateTime.Now.Ticks}.log");

            SimpleClass myClass = new SimpleClass();

            // Crate an instance of the delegate, pointing to the Logger()
            // function on the fl instance of a FileLogger.
            SimpleClass.LogHandler myLogger = new SimpleClass.LogHandler(fl.Logger);
            myClass.Process(myLogger);
            fl.Close();

            // The cool part here is that we didn't have to change the Process() function; the code to all the delegate is the same regardless of whether it refers to a static or member function.
        }

        private static void Demo2()
        {
            SimpleClass myClass =
                new SimpleClass();
            // Crate an instance of the delegate, pointing to the logging function.
            // This delegate will then be passed to the Process() function.
            SimpleClass.LogHandler myDelegate =
                new SimpleClass.LogHandler(Logger);
            myClass.Process(myDelegate);
        }

        private static void Demo1()
        {
            // Instantiation
            BasicDemoDelegate simpleDelegate1 = new BasicDemoDelegate(MyFunc);
            // Invocation
            simpleDelegate1();

            // Instantiation
            BasicDemoDelegate simpleDelegate2 = new BasicDemoDelegate(MyLoremIpsumFunc1);
            // Invocation
            simpleDelegate2();
        }

        public static void MyFunc()
        {
            var st = new StackTrace();

            Console.WriteLine($"{st.GetFrame(0).GetMethod().Name}: I was called by delegate...");
        }

        public static void MyLoremIpsumFunc1()
        {
            var st = new StackTrace();
            string message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            Console.WriteLine($"{st.GetFrame(0).GetMethod().Name}: I was called by delegate... Should print next message: {message}");
        }
        public static void MyLoremIpsumFunc2(string message)
        {
            var st = new StackTrace();
            Console.WriteLine($"{st.GetFrame(0).GetMethod().Name}: I was called by delegate... Should print next message: {message ?? "No data vanailable..."}");
        }

        // Static Function: To which is used in the Delegate. To call the Process()
        // function, we need to declare a logging function: Logger() that matches
        // the signature of the delegate.
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }

    }
}

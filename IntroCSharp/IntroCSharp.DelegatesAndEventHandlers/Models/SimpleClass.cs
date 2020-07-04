using System.Diagnostics;
using System.Threading;

namespace IntroCSharp.DelegatesAndEventHandlers.Models
{
    public class SimpleClass
    {
        public delegate void LogHandler(string message);

        // The use of the delegate is just like calling a function directly,
        // though we need to add a check to see if the delegate is null
        // (that is, not pointing to a function) before calling the function.
        public void Process(LogHandler logHandler)
        {
            var st = new StackTrace();
            logHandler?.Invoke($"Process() begin with {logHandler.GetType().Name} for {st.GetFrame(1).GetMethod().Name}...");

            Thread.Sleep(5000);
            logHandler?.Invoke($"Process() end with {logHandler.GetType().Name} for {st.GetFrame(1).GetMethod().Name}...");
        }
    }
}

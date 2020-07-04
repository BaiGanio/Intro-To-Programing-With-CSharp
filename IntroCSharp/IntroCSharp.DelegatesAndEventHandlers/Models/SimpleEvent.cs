using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.DelegatesAndEventHandlers.Models
{
    public class SimpleEvent
    {
        // Define a delegate named LogHandler, which will encapsulate
        // any method that takes a string as the parameter and returns no value
        public delegate void LogHandler(string message);

        // Define an Event based on the above Delegate
        public event LogHandler Log;

        // Instead of having the Process() function take a delegate
        // as a parameter, we've declared a Log event. Call the Event,
        // using the OnXXXX Method, where XXXX is the name of the Event.
        public void Process()
        {
            OnLog("Process() begin");
            OnLog("Process() end");
        }

        // By Default, create an OnXXXX Method, to call the Event
        protected void OnLog(string message)
        {
            Log?.Invoke(message);
        }
    }
}

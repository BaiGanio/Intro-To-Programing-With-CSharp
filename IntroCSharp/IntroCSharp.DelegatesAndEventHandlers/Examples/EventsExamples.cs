using IntroCSharp.Common.Models;
using IntroCSharp.DelegatesAndEventHandlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.DelegatesAndEventHandlers.Examples
{
    public static class EventsExamples
    {
        public static void DoExamples()
        {
            // 1.
            /* ========= Subscriber of the Event ============== */
            // It's now easier and cleaner to merely add instances
            // of the delegate to the event, instead of having to
            //Demo1();

            // 2.

            // Suppose you want to create a Clock class that uses events to notify potential subscribers 
            // whenever the local time changes value by one second
            /* ======================= Event Publisher =============================== */
            // Our subject -- it is this class that other classes
            // will observe. This class publishes one event:
            // SecondChange. The observers subscribe to that event.
            Demo2();
        }

        private static void Demo2()
        {

            // Create a new clock
            Clock theClock = new Clock();

            // Create the display and tell it to
            // subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            // Create a Log object and tell it
            // to subscribe to the clock
            LogClock lc = new LogClock();
            lc.Subscribe(theClock);

            // Get the clock started
            theClock.Run();
        }

        private static void Demo1()
        {
            FileLogger fl = new FileLogger($"../../../process-in-SimpleEvent-{DateTime.Now.Ticks}.log");
            SimpleEvent myClass = new SimpleEvent();

            // Subscribe the Functions Logger and fl.Logger
            myClass.Log += new SimpleEvent.LogHandler(Logger);
            myClass.Log += new SimpleEvent.LogHandler(fl.Logger);

            // The Event will now be triggered in the Process() Method
            myClass.Process();

            fl.Close();
        }

        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
    }
}

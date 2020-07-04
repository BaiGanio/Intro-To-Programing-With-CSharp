The Event model in C# finds its roots in the event programming model that is popular in asynchronous programming. 
The basic foundation behind this programming model is the idea of "publisher and subscribers." In this model, 
you have publishers who will do some logic and publish an "event." 
Publishers will then send out their event only to subscribers who have subscribed to receive the specific event.
In C#, any object can publish a set of events to which other applications can subscribe. 
When the publishing class raises an event, all the subscribed applications are notified. 
The following figure shows this mechanism.

The following important conventions are used with events:

Event Handlers in the .NET Framework return void and take two parameters.
The first paramter is the source of the event; that is the publishing object.
The second parameter is an object derived from EventArgs.
Events are properties of the class publishing the event.
The keyword event controls how the event property is accessed by the subscribing classes.
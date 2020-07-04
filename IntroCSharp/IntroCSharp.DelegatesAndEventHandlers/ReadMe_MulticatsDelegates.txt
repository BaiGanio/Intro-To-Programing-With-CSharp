Being able to point to member functions is nice, but there are more tricks you can do with delegates. 
In C#, delegates are multicast, which means that they can point to more than one function at a time 
(that is, they're based off the System.MulticastDelegate type). 
A multicast delegate maintains a list of functions that will all be called when the delegate is invoked. 

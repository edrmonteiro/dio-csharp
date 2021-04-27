Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
Frequency of use 2/5

###Participants
The classes and objects participating in this pattern are:

####Handler   (Approver)
defines an interface for handling the requests
(optional) implements the successor link
####ConcreteHandler   (Director, VicePresident, President)
handles requests it is responsible for
can access its successor
if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
####Client   (ChainApp)
initiates the request to a ConcreteHandler object on the chain



###Structural code in C#
This structural code demonstrates the Chain of Responsibility pattern in which several linked objects (the Chain) are offered the opportunity to respond to a request or hand it off to the object next in line.

###Real-world code in C#
This real-world code demonstrates the Chain of Responsibility pattern in which several linked managers and executives can respond to a purchase request or hand it off to a superior. Each position has can have its own set of rules which orders they can approve.

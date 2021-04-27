Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
Frequency of use 2/5

###Participants
The classes and objects participating in this pattern are:

####Mediator  (IChatroom)
defines an interface for communicating with Colleague objects
####ConcreteMediator  (Chatroom)
implements cooperative behavior by coordinating Colleague objects
knows and maintains its colleagues
####Colleague classes  (Participant)
each Colleague class knows its Mediator object
each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague




###Structural code in C#
This structural code demonstrates the Mediator pattern facilitating loosely coupled communication between different objects and object types. The mediator is a central hub through which all interaction must take place.

###Real-world code in C#
This real-world code demonstrates the Mediator pattern facilitating loosely coupled communication between different Participants registering with a Chatroom. The Chatroom is the central hub through which all communication takes place. At this point only one-to-one communication is implemented in the Chatroom, but would be trivial to change to one-to-many.

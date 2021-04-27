 Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
Frequency of use 4/5

###Participants
The classes and objects participating in this pattern are:

####Command  (Command)
declares an interface for executing an operation
####ConcreteCommand  (CalculatorCommand)
defines a binding between a Receiver object and an action
implements Execute by invoking the corresponding operation(s) on Receiver
####Client  (CommandApp)
creates a ConcreteCommand object and sets its receiver
####Invoker  (User)
asks the command to carry out the request
####Receiver  (Calculator)
knows how to perform the operations associated with carrying out the request.



###Structural code in C#
This structural code demonstrates the Command pattern which stores requests as objects allowing clients to execute or playback the requests.

###Real-world code in C#
This real-world code demonstrates the Command pattern used in a simple calculator with unlimited number of undo's and redo's. Note that in C#  the word 'operator' is a keyword. Prefixing it with '@' allows using it as an identifier.

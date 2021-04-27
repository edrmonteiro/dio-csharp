Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
Frequency of use 3/5

###Participants
The classes and objects participating in this pattern are:

####AbstractClass  (DataObject)
defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
implements a template method defining the skeleton of an algorithm. The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
####ConcreteClass  (CustomerDataObject)
implements the primitive operations to carry out subclass-specific steps of the algorithm



###Structural code in C#
This structural code demonstrates the Template method which provides a skeleton calling sequence of methods. One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence.

###Real-world code in C#
This real-world code demonstrates a Template method named Run() which provides a skeleton calling sequence of methods. Implementation of these steps are deferred to the CustomerDataObject subclass which implements the Connect, Select, Process, and Disconnect methods.

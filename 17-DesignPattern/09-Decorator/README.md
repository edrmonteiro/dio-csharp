Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
Frequency of use 3/5

###Participants
The classes and objects participating in this pattern are:

####Component   (LibraryItem)
defines the interface for objects that can have responsibilities added to them dynamically.
####ConcreteComponent   (Book, Video)
defines an object to which additional responsibilities can be attached.
####Decorator   (Decorator)
maintains a reference to a Component object and defines an interface that conforms to Component's interface.
####ConcreteDecorator   (Borrowable)
adds responsibilities to the component.



###Structural code in C#
This structural code demonstrates the Decorator pattern which dynamically adds extra functionality to an existing object.

###Real-world code in C#
This real-world code demonstrates the Decorator pattern in which 'borrowable' functionality is added to existing library items (books and videos).

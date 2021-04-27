Decouple an abstraction from its implementation so that the two can vary independently.
Frequency of use 3/5

###Participants
The classes and objects participating in this pattern are:

####Abstraction   (BusinessObject)
defines the abstraction's interface.
maintains a reference to an object of type Implementor.
####RefinedAbstraction   (CustomersBusinessObject)
extends the interface defined by Abstraction.
####Implementor   (DataObject)
defines the interface for implementation classes. This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
####ConcreteImplementor   (CustomersDataObject)
implements the Implementor interface and defines its concrete implementation.



###Structural code in C#
This structural code demonstrates the Bridge pattern which separates (decouples) the interface from its implementation. The implementation can evolve without changing clients which use the abstraction of the object.

###Real-world code in C#
This real-world code demonstrates the Bridge pattern in which a BusinessObject abstraction is decoupled from the implementation in DataObject. The DataObject implementations can evolve dynamically without changing any clients.

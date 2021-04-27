Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
Frequency of use 5/5

###Participants
The classes and objects participating in this pattern are:

####Iterator  (AbstractIterator)
defines an interface for accessing and traversing elements.
####ConcreteIterator  (Iterator)
implements the Iterator interface.
keeps track of the current position in the traversal of the aggregate.
####Aggregate  (AbstractCollection)
defines an interface for creating an Iterator object
####ConcreteAggregate  (Collection)
implements the Iterator creation interface to return an instance of the proper ConcreteIterator



###Structural code in C#
This structural code demonstrates the Iterator pattern which provides for a way to traverse (iterate) over a collection of items without detailing the underlying structure of the collection.

###Real-world code in C#
This real-world code demonstrates the Iterator pattern which is used to iterate over a collection of items and skip a specific number of items each iteration.

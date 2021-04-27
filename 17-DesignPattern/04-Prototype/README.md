Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
Frequency of use 3/5

###Participants
The classes and objects participating in this pattern are:

####Prototype  (ColorPrototype)
declares an interface for cloning itself
####ConcretePrototype  (Color)
implements an operation for cloning itself
####Client  (ColorManager)
creates a new object by asking a prototype to clone itself


###Structural code in C#
This structural code demonstrates the Prototype pattern in which new objects are created by copying pre-existing objects (prototypes) of the same class.

###Real-world code in C#
This real-world code demonstrates the Prototype pattern in which new Color objects are created by copying pre-existing, user-defined Colors of the same type.

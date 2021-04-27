Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
Frequency of use 4/5

###Participants
The classes and objects participating in this pattern are:

####Component   (DrawingElement)
declares the interface for objects in the composition.
implements default behavior for the interface common to all classes, as appropriate.
declares an interface for accessing and managing its child components.
(optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.
####Leaf   (PrimitiveElement)
represents leaf objects in the composition. A leaf has no children.
defines behavior for primitive objects in the composition.
####Composite   (CompositeElement)
defines behavior for components having children.
stores child components.
implements child-related operations in the Component interface.
####Client  (CompositeApp)
manipulates objects in the composition through the Component interface.



###Structural code in C#
This structural code demonstrates the Composite pattern which allows the creation of a tree structure in which individual nodes are accessed uniformly whether they are leaf nodes or branch (composite) nodes.

###Real-world code in C#
This real-world code demonstrates the Composite pattern used in building a graphical tree structure made up of primitive nodes (lines, circles, etc) and composite nodes (groups of drawing elements that make up more complex elements).

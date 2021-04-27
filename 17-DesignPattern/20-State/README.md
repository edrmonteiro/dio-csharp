Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
Frequency of use 3/5

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
This structural code demonstrates the State pattern which allows an object to behave differently depending on its internal state. The difference in behavior is delegated to objects that represent this state.

###Real-world code in C#
This real-world code demonstrates the State pattern which allows an Account to behave differently depending on its balance. The difference in behavior is delegated to State objects called RedState, SilverState and GoldState. These states represent overdrawn accounts, starter accounts, and accounts in good standing.

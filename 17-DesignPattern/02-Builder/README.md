Separate the construction of a complex object from its representation so that the same construction process can create different representations.
Frequency of use 2/5

###Participants
The classes and objects participating in this pattern are:

####Builder  (VehicleBuilder)
specifies an abstract interface for creating parts of a Product object
####ConcreteBuilder  (MotorCycleBuilder, CarBuilder, ScooterBuilder)
constructs and assembles parts of the product by implementing the Builder interface
defines and keeps track of the representation it creates
provides an interface for retrieving the product
####Director  (Shop)
constructs an object using the Builder interface
####Product  (Vehicle)
represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
includes classes that define the constituent parts, including interfaces for assembling the parts into the final result

###Structural code in C#
This structural code demonstrates the Builder pattern in which complex objects are created in a step-by-step fashion. The construction process can create different object representations and provides a high level of control over the assembly of the objects.

###Real-world code in C#
This real-world code demonstates the Builder pattern in which different vehicles are assembled in a step-by-step fashion. The Shop uses VehicleBuilders to construct a variety of Vehicles in a series of sequential steps.

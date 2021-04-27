Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
Frequency of use 5/5

###Participants
The classes and objects participating in this pattern are:

####AbstractFactory  (ContinentFactory)
declares an interface for operations that create abstract products
####ConcreteFactory   (AfricaFactory, AmericaFactory)
implements the operations to create concrete product objects
####AbstractProduct   (Herbivore, Carnivore)
declares an interface for a type of product object
####Product  (Wildebeest, Lion, Bison, Wolf)
defines a product object to be created by the corresponding concrete factory
implements the AbstractProduct interface
####Client  (AnimalWorld)
uses interfaces declared by AbstractFactory and AbstractProduct classes

##Structural code in C#
This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. Object creation has been abstracted and there is no need for hard-coded class names in the client code.

##Real-world code in C#
This real-world code demonstrates the creation of different animal worlds for a computer game using different factories. Although the animals created by the Continent factories are different, the interactions among the animals remain the same.
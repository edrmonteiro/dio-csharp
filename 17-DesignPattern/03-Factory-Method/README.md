Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
Frequency of use 5/5

###Participants
The classes and objects participating in this pattern are:

####Product  (Page)
defines the interface of objects the factory method creates
####ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage)
implements the Product interface
####Creator  (Document)
declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
may call the factory method to create a Product object.
####ConcreteCreator  (Report, Resume)
overrides the factory method to return an instance of a ConcreteProduct.

###Structural code in C#
This structural code demonstrates the Factory method offering great flexibility in creating different objects. The Abstract class may provide a default object, but each subclass can instantiate an extended version of the object.

###Real-world code in C#
This real-world code demonstrates the Factory method offering flexibility in creating different documents. The derived Document classes Report and Resume instantiate extended versions of the Document class. Here, the Factory Method is called in the constructor of the Document base class.

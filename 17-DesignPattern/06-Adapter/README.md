Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
Frequency of use 4/5

###Participants
The classes and objects participating in this pattern are:

####Target   (ChemicalCompound)
defines the domain-specific interface that Client uses.
####Adapter   (Compound)
adapts the interface Adaptee to the Target interface.
####Adaptee   (ChemicalDatabank)
defines an existing interface that needs adapting.
####Client   (AdapterApp)
collaborates with objects conforming to the Target interface.


###Structural code in C#
This structural code demonstrates the Adapter pattern which maps the interface of one class onto another so that they can work together. These incompatible classes may come from different libraries or frameworks.

###Real-world code in C#
This real-world code demonstrates the use of a legacy chemical databank. Chemical compound objects access the databank through an Adapter interface.

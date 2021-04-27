Ensure a class has only one instance and provide a global point of access to it.
Frequency of use 4/5

###Participants
The classes and objects participating in this pattern are:

####Singleton   (LoadBalancer)
defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
responsible for creating and maintaining its own unique instance.


###Structural code in C#
This structural code demonstrates the Singleton pattern which assures only a single instance (the singleton) of the class can be created.

###Real-world code in C#
This real-world code demonstrates the Singleton pattern as a LoadBalancing object. Only a single instance (the singleton) of the class can be created because servers may dynamically come on- or off-line and every request must go throught the one object that has knowledge about the state of the (web) farm.

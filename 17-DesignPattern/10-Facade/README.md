Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.
Frequency of use 5/5

###Participants
The classes and objects participating in this pattern are:

####Facade   (MortgageApplication)
knows which subsystem classes are responsible for a request.
delegates client requests to appropriate subsystem objects.
Subsystem classes   (Bank, Credit, Loan)
implement subsystem functionality.
handle work assigned by the Facade object.
have no knowledge of the facade and keep no reference to it.



###Structural code in C#
This structural code demonstrates the Facade pattern which provides a simplified and uniform interface to a large subsystem of classes

###Real-world code in C#
This real-world code demonstrates the Facade pattern as a MortgageApplication object which provides a simplified interface to a large subsystem of classes measuring the creditworthyness of an applicant.

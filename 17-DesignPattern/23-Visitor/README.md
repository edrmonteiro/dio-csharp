Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.
Frequency of use 1/5

###Participants
The classes and objects participating in this pattern are:

####Visitor  (Visitor)
declares a Visit operation for each class of ConcreteElement in the object structure. The operation's name and signature identifies the class that sends the Visit request to the visitor. That lets the visitor determine the concrete class of the element being visited. Then the visitor can access the elements directly through its particular interface
####ConcreteVisitor  (IncomeVisitor, VacationVisitor)
implements each operation declared by Visitor. Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure. ConcreteVisitor provides the context for the algorithm and stores its local state. This state often accumulates results during the traversal of the structure.
####Element  (Element)
defines an Accept operation that takes a visitor as an argument.
####ConcreteElement  (Employee)
implements an Accept operation that takes a visitor as an argument
####ObjectStructure  (Employees)
can enumerate its elements
may provide a high-level interface to allow the visitor to visit its elements
may either be a Composite (pattern) or a collection such as a list or a set



###Structural code in C#
This structural code demonstrates the Visitor pattern in which an object traverses an object structure and performs the same operation on each node in this structure. Different visitor objects define different operations.

###Real-world code in C#
This real-world code demonstrates the Visitor pattern in which two objects traverse a list of Employees and performs the same operation on each Employee. The two visitor objects define different operations -- one adjusts vacation days and the other income.
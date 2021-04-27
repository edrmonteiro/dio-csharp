Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
Frequency of use 4/5

###Participants
The classes and objects participating in this pattern are:

####Strategy  (SortStrategy)
declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a ConcreteStrategy
####ConcreteStrategy  (QuickSort, ShellSort, MergeSort)
implements the algorithm using the Strategy interface
####Context  (SortedList)
is configured with a ConcreteStrategy object
maintains a reference to a Strategy object
may define an interface that lets Strategy access its data.



###Structural code in C#
This structural code demonstrates the Strategy pattern which encapsulates functionality in the form of an object. This allows clients to dynamically change algorithmic strategies.

###Real-world code in C#
This real-world code demonstrates the Strategy pattern which encapsulates sorting algorithms in the form of sorting objects. This allows clients to dynamically change sorting strategies including Quicksort, Shellsort, and Mergesort.

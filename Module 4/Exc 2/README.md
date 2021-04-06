# Collections and LINQ
## Exercise: check collection is sorted
It's required to implement method <code>IsSorted</code> which takes a collection with strings (<code>IEnumerable&lt;string&gt;</code>) and returns <code>bool</code> result <code>true</code> if the collection is sorted int alphabetical order; otherwise - <code>false</code>.  
E.g. ["1", "2"] is sorted in alphabetical order, but the ["3", "2"] isn't.

## Knowledge required
1. Basic comparision operators, and string comaparizion
2. Basic collections supported in .NET (part of BCL) and their properties, methods
3. Basic read operations with collections

## Guidlines
1. Download exercise solution locally and open it in IDE (e.g. Visual Studio)
2. Implement 1 method <code>IsSorted</code> in the <code>StringCollectionsHelper</code> class
3. Debug and test your implementation.  
E.g. *Tests* project contains set of unit tests which can be used to check solution.

## Extra points
1. Think whether any additional tests can be added to check implementation (e.g. consider edge cases).
2. Think and estimate your implementation execution time and memory consuptions depends on the size of input data (computational complexity).

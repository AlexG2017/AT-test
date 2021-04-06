# Collections and LINQ
## Exercise: check collections (simple objects) for equality
It's required to implement 2 methods <code>IsEqual</code> and <code>IsSequentialEqual</code>, both methods take 2 collections with strings (<code>ICollection&lt;string&gt;</code>) and returns <code>bool</code> result in the cases below:
1. The <code>IsSequentialEqual</code> returns <code>true</code> if both collections sequantially equal; otherwise - <code>false</code>.  
E.g. ["1", "2"] is secuential equal to ["1", "2"], but no to ["2", "1"]
2. The <code>IsEqual</code> returns <code>true</code> if both collections contains the same elements and the same number; otherwise - <code>false</code>.  
E.g. ["1", "2"] is equal to ["1", "2"] and to ["2", "1"], but not equal to the ["1"] or ["3", "2"].

## Knowledge required
1. Basic comparision operators, and string comaparizion
2. Basic collections supported in .NET (part of BCL) and their properties, methods
3. Basic read operations with collections
4. LINQ is a plus

## Guidlines
1. Download exercise solution locally and open it in IDE (e.g. Visual Studio)
2. Implement 2 methods <code>IsEqual</code> and <code>IsSequentualEqual</code> in the <code>StringCollectionsComparer</code> class
3. Debug and test your implementation.  
E.g. *Tests* project contains set of unit tests which can be used to check solution.

## Extra points
1. Think whether any additional tests can be added to check implementation (e.g. consider edge cases).
2. Think and estimate your implementation execution time depends on the size of input data (computational complexity).
3. Is any way/ideas to decrease this complexity (e.g. consider shorcuts, etc.).

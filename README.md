# C# Reference vs. Value Type Pitfall
This example demonstrates a common pitfall in C# related to understanding reference types (like classes) versus value types (like ints, structs).

## The Bug
The `Bug.cs` file shows a scenario where modifying an object assigned to another variable modifies the original object as well, because the second variable is merely a reference to the first.  This often leads to unexpected behavior if you expect a new independent copy to be created.

## Solution
The `BugSolution.cs` demonstrates how to create a deep copy using memberwise cloning to prevent unintended modification of the original object.  If dealing with complex objects, you will likely need to implement more sophisticated cloning mechanisms (member by member cloning, serialization, etc.) to ensure a completely independent copy is made.

## Learning Points
* Understand the distinction between reference types and value types in C#.
* Be aware that assigning a reference type variable does not create a copy; instead, you are copying the reference.
* Learn appropriate methods to create deep copies when needed (e.g. cloning).
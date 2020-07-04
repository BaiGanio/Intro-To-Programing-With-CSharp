/*
     * Structs can have:
     * 1. Private fields
     * 2. Public properties
     * 3. Constructors
     * 4. Methods
     * 
     * Struct is a value type - they are stored in the Stack.
     * Class is a reference  type - stored in the Heap.
     * 
     * Value types hold their value in memory where they are declared & are destroyd immediately after the scope is lost.
     * Reference types hold a reference to an object in memory & after the scope is lost only the reference variable is destroyed. The Object is later destroyed by the garbage collector.
     * 
     * Struct in .NET are int(System.Int32), double(System.Double)
     * 
     * If we use 'sealed' keyword we cannot be able to use the sealed class like a base class. 
     * Struct are sealed types, so classes & structs cannot inherit from another struct.
     */
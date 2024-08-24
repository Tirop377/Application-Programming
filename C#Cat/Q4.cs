using System;
using System.Runtime.Intrinsics.X86;





//
//Q4

/*
 * Value Types: Copy the actual data when assigned to another variable, stored on the stack.
 * Reference Types: Copy the reference to the data when assigned to another variable, stored on the heap.
 * Performance Considerations: Value types are faster for small, simple data, while reference types are 
 * more flexible and useful for complex data structures but come with some performance overhead. 
 * Understanding when and how to use each can lead to more efficient and reliable code.
 */


class Program4
{
    static void Main()
    {
        // Value type demonstration
        int a = 10;
        int b = a; // Copying value
        b = 20; // Changing b does not affect a
        Console.WriteLine($"Value Types: a = {a}, b = {b}");

        // Reference type demonstration with arrays
        int[] array1 = { 1, 2, 3 };
        int[] array2 = array1; // Copying reference
        array2[0] = 10; // Changing array2 also changes array1
        Console.WriteLine($"Reference Types (Array): array1[0] = {array1[0]}, array2[0] = {array2[0]}");

        // Demonstrating the use of Object.ReferenceEquals with reference types
        Console.WriteLine($"Are array1 and array2 the same object? {Object.ReferenceEquals(array1, array2)}");

        // Demonstrating with strings (reference type but behaves like value type due to immutability)
        string str1 = "Hello";
        string str2 = str1; // Copying reference
        str2 = "World"; // Changing str2 does not affect str1 because strings are immutable
        Console.WriteLine($"Reference Types (String): str1 = {str1}, str2 = {str2}");

        // Demonstrating the use of Object.ReferenceEquals with strings
        string str3 = "Hello";
        string str4 = str3;
        Console.WriteLine($"Are str3 and str4 the same object before change? {Object.ReferenceEquals(str3, str4)}");

        str4 = "World";
        Console.WriteLine($"Are str3 and str4 the same object after change? {Object.ReferenceEquals(str3, str4)}");
    }
}


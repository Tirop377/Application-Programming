/*

Differences Between List<T>, Queue<T>, and Stack<T> in C#
1. List<T>

    Description: A List<T> is a dynamic array that can grow and shrink in size. 
                 It allows random access to elements via an index and can store elements of any type.
    Characteristics:
        Dynamic Size: Automatically resizes as elements are added or removed.
        Random Access: Supports accessing elements by their index.
        Order Preservation: Maintains the order of elements as they are inserted.
    Use Cases:
        Storing a Collection of Items: When you need to keep a list of items where the order 
        matters and random access is required. For example, managing a list of products in an e-commerce application.
        Sorting and Searching: When you need to sort or search through a collection of items.

2. Queue<T>

    Description: A Queue<T> is a First-In-First-Out (FIFO) data structure where elements are added at the end and removed from the front.
    Characteristics:
        FIFO: The first element added is the first one to be removed.
        No Random Access: You can only access the element at the front.
    Use Cases:
        Task Scheduling: Managing tasks in a system where they must be executed in the order they were received, such as print jobs in a printer queue.
        Order Processing: Handling customer orders in the sequence they are received.

3. Stack<T>

    Description: A Stack<T> is a Last-In-First-Out (LIFO) data structure where elements are added and removed from the top.
    Characteristics:
        LIFO: The last element added is the first one to be removed.
        No Random Access: You can only access the element at the top.
    Use Cases:
        Undo Functionality: Implementing undo features in applications, where the most recent actions are undone first.
        Expression Evaluation: Evaluating mathematical expressions in compilers or calculators.

Example Scenarios:

    List<T>: Use when you need to store and access elements by their position, 
    such as maintaining a list of registered users where you might frequently access users by their index.

    Queue<T>: Use in scenarios where the order of processing matters, 
    such as handling customer support tickets in the order they are received.

    Stack<T>: Use when the most recent element should be processed first, 
    such as tracking browser history where the last visited page should be returned first.

*/



// a) Program Demonstration: Bank Queue with VIP Customers

using System;
using System.Collections.Generic;

class BankQueue
{
    static void Main(string[] args)
    {
        Queue<string> regularCustomers = new Queue<string>();
        Queue<string> vipCustomers = new Queue<string>();

        // Regular customers joining the queue
        regularCustomers.Enqueue("Alice");
        regularCustomers.Enqueue("Bob");
        regularCustomers.Enqueue("Charlie");

        // VIP customers joining the queue
        vipCustomers.Enqueue("David");
        vipCustomers.Enqueue("Eva");

        // Processing customers in the queue
        while (vipCustomers.Count > 0 || regularCustomers.Count > 0)
        {
            // Prioritize VIP customers
            if (vipCustomers.Count > 0)
            {
                Console.WriteLine($"Serving VIP Customer: {vipCustomers.Dequeue()}");
            }
            else if (regularCustomers.Count > 0)
            {
                Console.WriteLine($"Serving Regular Customer: {regularCustomers.Dequeue()}");
            }
        }
    }
}

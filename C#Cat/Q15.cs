/*

Abstraction is a fundamental concept in object-oriented programming (OOP) that focuses
on exposing only the essential features of an object while hiding the implementation details. 
In C#, abstraction is implemented using abstract classes and interfaces, which allow 
you to define a blueprint for a group of related objects without dictating how those objects should be implemented.

Abstract Classes

    Purpose: Abstract classes are used to define common characteristics and behaviors that 
    derived classes must implement or override. An abstract class cannot be instantiated directly.
    Implementation:
        An abstract class is declared using the abstract keyword.
        It can contain both abstract methods (methods without a body) and concrete methods (methods with a body).
        Derived classes must implement all abstract methods defined in the abstract class.

Interfaces

    Purpose: Interfaces define a contract that a class must follow. Unlike abstract classes, 
    interfaces cannot contain any implementation. They only contain method, property, event, or indexer declarations.
    Implementation:
        An interface is declared using the interface keyword.
        A class or struct that implements an interface must provide concrete implementations for all members defined in the interface.
        A class can implement multiple interfaces, allowing for more flexible design.


Scenarios Where Abstraction Simplifies Code and Enhances Maintainability:

    Code Reusability: By defining common functionality in an abstract class, multiple derived classes 
                      can reuse the code, reducing duplication.

    Loose Coupling: Using interfaces allows you to decouple the code's implementation 
                    from its definition, making it easier to modify or extend the code without affecting other parts of the application.

    Maintainability: Abstract classes and interfaces provide a clear contract for developers, 
                     ensuring consistency and making the code easier to understand and maintain.

*/

// a) Abstract Class Shape and Derived Classes
using System;

abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    // Abstract method
    public abstract void Draw();

    // Non-abstract method
    public void DisplayInfo()
    {
        Console.WriteLine($"This is a {Color} shape.");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    // Implementing the abstract method
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} Circle with radius {Radius}");
    }

    // Additional method specific to Circle
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Square : Shape
{
    public double SideLength { get; set; }

    public Square(string color, double sideLength) : base(color)
    {
        SideLength = sideLength;
    }

    // Implementing the abstract method
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} Square with side length {SideLength}");
    }

    // Additional method specific to Square
    public double CalculateArea()
    {
        return SideLength * SideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle("Red", 5.0);
        circle.Draw();
        circle.DisplayInfo();
        Console.WriteLine($"Area: {((Circle)circle).CalculateArea()}\n");

        Shape square = new Square("Blue", 3.0);
        square.Draw();
        square.DisplayInfo();
        Console.WriteLine($"Area: {((Square)square).CalculateArea()}");
    }
}

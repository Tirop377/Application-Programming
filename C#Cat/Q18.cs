/*
 * Purpose of Interfaces:
    In C#, an interface is a contract that defines a set of methods and properties 
    that a class must implement. Interfaces do not provide the implementation of these 
    methods; they only declare what methods or properties a class should have.

    Key Points:
    Contract: An interface defines a contract that implementing classes must follow.
    No Implementation: Interfaces declare methods and properties but do not provide any 
    implementation. This is done by the classes that implement the interface.
    Multiple Implementations: A single interface can be implemented by multiple classes, 
    and a class can implement multiple interfaces.

2. Benefits of Using Interfaces:
    Loose Coupling:
    Definition: Loose coupling means that components or classes are independent of each other,
    and changes in one component have minimal impact on others.
    How Interfaces Promote Loose Coupling: By programming to an interface rather than a concrete 
    implementation, you decouple the code that uses the interface from the code that implements it. This 
    way, changes to the implementation class do not affect the code that depends on the interface.

    Code Reusability:
    Definition: Code reusability means writing code that can be used in multiple places without modification.
    How Interfaces Promote Code Reusability: Interfaces allow you to write code that works with any implementation
    of the interface. This means you can reuse code that depends on an interface with any class that implements that 
    interface.

    Supports Multiple Inheritance:
    Definition: C# does not support multiple inheritance of classes, but it does allow a class to implement multiple 
    interfaces.
    Benefit: This allows a class to inherit behavior from multiple sources, providing greater flexibility in designing
    complex systems.

    Facilitates Dependency Injection:

    Definition: Dependency injection is a design pattern used to achieve Inversion of Control (IoC) between classes and 
    their dependencies.
    Benefit: Interfaces are often used in dependency injection to provide a way to inject dependencies at runtime, 
    enhancing testability and flexibility.
 * 
 */


//(a)
using System;

public interface IDrive
{
    void Drive();
}

public class Car : IDrive
{
    public void Drive()
    {
        Console.WriteLine("The car drives smoothly on the highway.");
    }
}

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create instances of Car and Bike
        IDrive myCar = new Car();
        IDrive myBike = new Bike();

        // Create a list of IDrive objects
        List<IDrive> vehicles = new List<IDrive>
        {
            myCar,
            myBike
        };

        // Iterate through the list and call the Drive method on each object
        foreach (IDrive vehicle in vehicles)
        {
            vehicle.Drive();
        }
    }
}

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create instances of Car and Bike
        IDrive myCar = new Car();
        IDrive myBike = new Bike();

        // Create a list of IDrive objects
        List<IDrive> vehicles = new List<IDrive>
        {
            myCar,
            myBike
        };

        // Iterate through the list and call the Drive method on each object
        foreach (IDrive vehicle in vehicles)
        {
            vehicle.Drive();
        }
    }
}



//b
/*
 * Abstract classes in C# are classes that cannot be instantiated directly. They are designed to be used as 
 * base classes from which other classes can inherit. Abstract classes can contain both abstract methods 
 * (methods without implementation) and concrete methods (methods with implementation).

Key Features of Abstract Classes:
Abstract Methods:
    Methods declared as abstract in an abstract class do not have an implementation and must be implemented by 
    derived classes.
Concrete Methods:
    Abstract classes can also contain methods with full implementations. Derived classes inherit these methods 
    and can use or override them.
Constructors and Fields:
    Abstract classes can have constructors, fields, and properties, which can be used to initialize and store data
    relevant to derived classes.
Access Modifiers:
    Abstract classes can define access modifiers for their members, allowing control over the visibility and 
    accessibility of methods and properties.

Differences Between Abstract Classes and Interfaces
Purpose:
Abstract Classes: Designed to provide a common base with shared code and define common functionality that derived 
    classes can inherit and extend. Useful when you have a base class that should not be instantiated but should provide default behavior or state.
Interfaces: Define a contract that implementing classes must follow. They do not provide any implementation but 
    specify what methods or properties a class should implement.

Inheritance:
Abstract Classes: A class can inherit only one abstract class (single inheritance). Abstract classes allow for code
    sharing among related classes.
Interfaces: A class can implement multiple interfaces (multiple inheritance), which allows for combining different 
    sets of behaviors.

Implementation:
Abstract Classes: Can contain both abstract methods (without implementation) and concrete methods (with implementation).
    They can also have fields and constructors.
Interfaces: Only define method signatures and properties without any implementation. Interfaces do not have f
    ields or constructors.

Usage:
Abstract Classes: Use when you have a common base with shared code and need to provide some default behavior
    or state.
Interfaces: Use when you need to define a contract for classes that can have different implementations and
    when you want to allow a class to inherit behaviors from multiple sources.
 */


//(c)
using System;

public abstract class Animal
{
    public abstract void MakeSound();
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a list of Animal objects
        List<Animal> animals = new List<Animal>
        {
            new Dog(),
            new Cat()
        };

        // Iterate through the list and call MakeSound on each object
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}


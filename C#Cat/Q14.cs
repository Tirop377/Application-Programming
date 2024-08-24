/*

Polymorphism is a core concept in object-oriented programming (OOP) 
that allows objects of different classes to be treated as objects of 
a common base class. In C#, polymorphism enables methods to be defined in a 
base class and overridden in derived classes, allowing the same method to 
behave differently depending on the object it is called on.

Types of Polymorphism in C#
Compile-time Polymorphism (Static Binding):

Achieved using method overloading and operator overloading.
The method to be invoked is determined at compile time.
Runtime Polymorphism (Dynamic Binding):

Achieved using method overriding with base and derived classes.
The method to be invoked is determined at runtime, depending on the object type.
Achieving Polymorphism in C#
Polymorphism in C# is typically achieved through:

Method Overriding: This is where a derived class provides a specific implementation 
of a method that is already defined in its base class.

Interfaces and Abstract Classes: Both can define methods that must be implemented
by derived classes or implementing classes, providing polymorphic behavior.
 */

using System;

public class Animal
{
    // Base class method declared as virtual to allow overriding
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}


public class Dog : Animal
{
    // Override the Speak method to provide specific implementation
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    // Override the Speak method to provide specific implementation
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

public class Bird : Animal
{
    // Override the Speak method to provide specific implementation
    public override void Speak()
    {
        Console.WriteLine("The bird chirps.");
    }
}

public class Program
{
    public static void Main()
    {
        // Create instances of the derived classes
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        Animal myBird = new Bird();

        // Polymorphism: Call the Speak method on base class reference
        myDog.Speak();  // Output: The dog barks.
        myCat.Speak();  // Output: The cat meows.
        myBird.Speak(); // Output: The bird chirps.

        // Demonstrating polymorphism with an array of Animal objects
        Animal[] animals = { myDog, myCat, myBird };

        foreach (Animal animal in animals)
        {
            animal.Speak(); // Calls the appropriate method based on the actual object type
        }
    }
}


//(b)

using System;

public interface IDrive
{
    void Drive();
}
public class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    // A method that can be overridden in derived classes
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
}
public class Car : Vehicle, IDrive
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car - Brand: {Brand}, Year: {Year}");
    }

    // Implement the Drive method from the IDrive interface
    public void Drive()
    {
        Console.WriteLine("The car drives smoothly on the highway.");
    }
}
public class Bike : Vehicle, IDrive
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"Bike - Brand: {Brand}, Year: {Year}");
    }

    // Implement the Drive method from the IDrive interface
    public void Drive()
    {
        Console.WriteLine("The bike zips through the city streets.");
    }
}

public class Program
{
    public static void Main()
    {
        // Create instances of Car and Bike
        Vehicle myCar = new Car { Brand = "Tesla", Year = 2024 };
        Vehicle myBike = new Bike { Brand = "Yamaha", Year = 2022 };

        // Display information about each vehicle
        myCar.DisplayInfo();  // Output: Car - Brand: Tesla, Year: 2024
        myBike.DisplayInfo(); // Output: Bike - Brand: Yamaha, Year: 2022

        // Polymorphism: Treating each object as IDrive and calling the Drive method
        IDrive carDriver = myCar as IDrive;
        IDrive bikeDriver = myBike as IDrive;

        if (carDriver != null)
        {
            carDriver.Drive();  // Output: The car drives smoothly on the highway.
        }

        if (bikeDriver != null)
        {
            bikeDriver.Drive(); // Output: The bike zips through the city streets.
        }
    }
}


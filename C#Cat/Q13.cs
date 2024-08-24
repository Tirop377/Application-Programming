using System;

/*
 Inheritance is a fundamental concept in object-oriented programming (OOP) that allows 
one class (called the derived or child class) to inherit properties and methods from 
another class (called the base or parent class). Inheritance promotes code reusability, 
extensibility, and organization by enabling new classes to build on existing ones.

Access Modifiers in the Context of Inheritance
Access modifiers determine the visibility and accessibility of class members in C#. The most common access modifiers are public, protected, internal, and private. These modifiers play a significant role in inheritance:

public:

Members declared as public are accessible from any class in any assembly.
Inherited classes can access public members of their base class.
protected:

Members declared as protected are accessible within their own class and by derived classes.
Useful when you want to allow derived classes to access certain members, but keep them hidden from the outside world.
internal:

Members declared as internal are accessible only within the same assembly (project).
Not accessible from other assemblies, even if inherited.
private:

Members declared as private are accessible only within their own class.
Not accessible by derived classes, so they are not inherited.
 */

using System;

public class Animal
{
    // Base class method
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Override the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    // Override the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

public class Bird : Animal
{
    // Override the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The bird chirps.");
    }
}

public class Program
{
    public static void Main()
    {
        // Polymorphism: Using the base class reference to refer to derived class objects
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        Animal myBird = new Bird();

        // Call the overridden Speak method
        myDog.Speak();  // Output: The dog barks.
        myCat.Speak();  // Output: The cat meows.
        myBird.Speak(); // Output: The bird chirps.

        // Demonstrating polymorphism with an array of Animal objects
        Animal[] animals = { myDog, myCat, myBird };

        foreach (Animal animal in animals)
        {
            animal.Speak();
        }
    }
}


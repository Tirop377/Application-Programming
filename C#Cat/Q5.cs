
//Q5
/*
 * Encapsulation is one of the fundamental principles of object-oriented programming (OOP) in C#.
 * It refers to the practice of bundling the data (fields) and the methods that operate on that
 * data into a single unit, typically a class. Encapsulation helps protect the internal state 
 * of an object and ensures that the object's data is accessed and modified only through 
 * well-defined interfaces.
 */


//(a)

public class Person
{
    // Private fields
    private string _name;
    private int _age;

    // Public property for Name
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be null or empty.");
            _name = value;
        }
    }

    // Public property for Age
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Age cannot be negative.");
            _age = value;
        }
    }

    // Constructor to initialize the Person object
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // ToString method to provide a string representation of the Person object
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

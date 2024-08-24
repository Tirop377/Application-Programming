//Q1 
//
class Calculator
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform calculations
        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = 0;

        if (num2 != 0)
        {
            division = num1 / num2;
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }

        // Display results
        Console.WriteLine($"Addition: {addition}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");

        if (num2 != 0)
        {
            Console.WriteLine($"Division: {division}");
        }
    }


    //(a)
    static double CalculateAverage(int[] numbers)
    {
        // Handle the edge case for an empty array
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }

        // Calculate the sum of all elements
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // Calculate the average
        double average = (double)sum / numbers.Length;
        return average;
    }
}


//(b)
/*
 * Constructors are special methods in C# that are automatically invoked when
 * an object of a class is created. Their primary role is to initialize the newly
 * created object. Constructors typically set initial values for the object’s fields
 * or perform any setup procedures required before the object is used.
 * 
 *     The difference of constructors from other methods
 * 1. No Return Type: Constructors do not have a return type, not even void. This is one of
 *    the key distinctions between constructors and other methods.
 * 2. Same Name as the Class: A constructor has the same name as the class in which it is defined.
 * 3. Automatic Invocation: Constructors are called automatically when an object is instantiated.
 */
class Product
{
    // Fields
    public string Name;
    public int Id;
    public double Price;

    // Default constructor
    public Product()
    {
        // Initialize with default values
        Name = "Unknown";
        Id = 0;
        Price = 0.0;
    }

    // Overloaded constructor
    public Product(string name, int id, double price)
    {
        // Initialize with provided values
        Name = name;
        Id = id;
        Price = price;
    }

    // Method to display product details
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Price: {Price:C}");
    }
}

class Program2
{
    static void Main()
    {
        // Using the default constructor
        Product defaultProduct = new Product();
        defaultProduct.DisplayProductInfo();

        // Using the overloaded constructor
        Product specificProduct = new Product("Laptop", 12345, 999.99);
        specificProduct.DisplayProductInfo();
    }
}


//(c)

class Employee
{
    // Fields
    public string Name { get; set; }
    public int ID { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    // Constructor that takes only name and ID
    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
        Department = "Unknown";  // Default value
        Salary = 0.0;             // Default value
    }

    // Secondary constructor that also takes department and salary
    public Employee(string name, int id, string department, double salary)
    {
        Name = name;
        ID = id;
        Department = department;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}, Department: {Department}, Salary: {Salary:C}");
    }
}

class Program3
{
    static void Main()
    {
        // Creating an instance using the first constructor
        Employee employee1 = new Employee("John Doe", 101);
        employee1.DisplayEmployeeInfo();

        // Creating an instance using the second constructor
        Employee employee2 = new Employee("Jane Smith", 102, "Human Resources", 75000.0);
        employee2.DisplayEmployeeInfo();
    }
}


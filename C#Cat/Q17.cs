// 1. Method to Return the Largest and Smallest Integers in a List
using System;
using System.Collections.Generic;

class Program
{
    public static (int largest, int smallest) FindLargestAndSmallest(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("The list is empty or null.");
        }

        int largest = int.MinValue;
        int smallest = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }

            if (number < smallest)
            {
                smallest = number;
            }
        }

        return (largest, smallest);
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 45, -5, 78, 34, 12 };
        var result = FindLargestAndSmallest(numbers);
        Console.WriteLine($"Largest: {result.largest}, Smallest: {result.smallest}");
    }
}


// 1a. Program to Calculate the Sum of Unique Integers Until a Negative Number is Entered

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        int sum = 0;
        
        while (true)
        {
            Console.Write("Enter an integer (negative to stop): ");
            int number = int.Parse(Console.ReadLine());
            
            if (number < 0)
            {
                break;
            }
            
            if (uniqueNumbers.Add(number))
            {
                sum += number;
            }
        }
        
        Console.WriteLine($"Sum of unique integers: {sum}");
    }
}


// 1b. Program Demonstrating the Use of an Enum for Days of the Week
using System;

class Program
{
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void Main()
    {
        DaysOfWeek today = DaysOfWeek.Saturday;

        switch (today)
        {
            case DaysOfWeek.Saturday:
            case DaysOfWeek.Sunday:
                Console.WriteLine($"{today} is a weekend!");
                break;
            default:
                Console.WriteLine($"{today} is a weekday.");
                break;
        }
    }
}


// 1c. Program to Reverse a String Input
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversed = new string(charArray);
        Console.WriteLine($"Reversed string: {reversed}");
    }
}



// 1d. Program Demonstrating the Use of a Dictionary to Store and Retrieve Student Grades
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> studentGrades = new Dictionary<string, double>();

        studentGrades.Add("Alice", 85.5);
        studentGrades.Add("Bob", 90.0);
        studentGrades.Add("Charlie", 78.3);

        foreach (var student in studentGrades)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }

        // Handling multiple data types
        Dictionary<int, string> studentIDs = new Dictionary<int, string>();
        studentIDs.Add(101, "Alice");
        studentIDs.Add(102, "Bob");
        studentIDs.Add(103, "Charlie");

        foreach (var id in studentIDs)
        {
            Console.WriteLine($"Student ID {id.Key} is {id.Value}");
        }
    }
}


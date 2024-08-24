

//Q8


public class Program6
{
    public static void Main()
    {
        Console.WriteLine("Please enter an integer:");

        // Read the user input
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int number))
        {
            // Use if-else conditions to determine the message
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

//(a)
/*
 * A while loop repeatedly executes a block of code as long as a specified
 * condition is true. The condition is evaluated before the execution of each iteration.
 * 
 * A do-while loop is similar to a while loop but guarantees that the block of code will be
 * executed at least once. The condition is evaluated after the execution of each iteration.
 */

//(b)


public class FactorialCalculator
{
    public static void Main()
    {
        Console.WriteLine("Please enter an integer:");

        // Read user input
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int number))
        {
            // Check if the number is odd
            if (number % 2 != 0)
            {
                long factorial = 1;

                // Calculate factorial using a loop
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"The factorial of {number} is {factorial}");
            }
            else
            {
                Console.WriteLine("The number is even. Factorial calculation is only for odd numbers.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}


//(c)

public class TrianglePatterns
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of rows for the triangle:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Right-Angled Triangle:");
        // Right-angled triangle
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line after each row
        }

        Console.WriteLine("\nInverted Right-Angled Triangle:");
        // Inverted right-angled triangle
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
}






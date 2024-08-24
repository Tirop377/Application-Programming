//Q6
/*
 * A single-dimensional array is a simple list of elements of the same type.
 * It’s a basic form of an array where each element is accessed by a single index.
 * 
 * Use Case: Single-dimensional arrays are used when you need a straightforward 
 * list of items. For instance, if you're tracking the scores of students in a 
 * test where each score is an integer, a single-dimensional array would be suitable.
 * 
 * A jagged array is an array of arrays. Each element of a jagged array is itself 
 * an array, which means the inner arrays can have different lengths. This provides 
 * more flexibility than a single-dimensional or multi-dimensional array.
 * Use Case: Jagged arrays are useful when you have a collection of arrays 
 * where each array can have a different length. For example, if you're working with
 * a scheduling system where each department has a varying number of employees, 
 * a jagged array can accommodate this variability.
 */

//(a)

public class ArraySumCalculator
{
    public static int SumOfElements(int?[,] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");

        int sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // Check if the element is not null and add to sum
                if (array[i, j].HasValue)
                {
                    sum += array[i, j].Value;
                }
            }
        }

        return sum;
    }

    public static void Main()
    {
        // Example usage:
        int?[,] irregularArray = {
            { 1, 2, null },
            { 4, null, 6 },
            { 7, 8, 9 }
        };

        int sum = SumOfElements(irregularArray);
        Console.WriteLine("Sum of elements: " + sum); // Output: Sum of elements: 37
    }
}



//(b)

public enum Color
{
    Red,
    Green,
    Blue
}


public class Shape
{
    // Nested class Circle
    public class Circle
    {
        // Property to hold the color of the circle
        public Color CircleColor { get; set; }

        // Constructor to initialize Circle with a specific color
        public Circle(Color color)
        {
            CircleColor = color;
        }

        // Method to display the circle's color
        public void DisplayColor()
        {
            Console.WriteLine($"The color of the circle is {CircleColor}");
        }
    }
}

public class Program5
{
    public static void Main()
    {
        // Example usage:
        Shape.Circle myCircle = new Shape.Circle(Color.Red);
        myCircle.DisplayColor(); // Output: The color of the circle is Red
    }
}



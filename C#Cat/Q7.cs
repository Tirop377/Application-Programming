//Q7
/*
 * The try block contains the code that might throw an exception. It’s the
 * section where you anticipate that an exception might occur.
 * 
 * The catch block is used to handle exceptions thrown in the try block. You can 
 * have multiple catch blocks to handle different types of exceptions or a general
 * catch block for unexpected exceptions.
 * 
 * The finally block is optional and contains code that is always executed, 
 * regardless of whether an exception was thrown or caught. It’s typically used for 
 * cleanup operations, such as closing files or releasing resources.
 */


//(a)

public class ListManagement
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        try
        {
            // Attempt to access an element at an invalid index
            try
            {
                Console.WriteLine("Accessing element at index 10:");
                int value = numbers[10]; // This will throw an IndexOutOfRangeException
                Console.WriteLine("Value: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
                // Nested try-catch block for demonstrating nested error handling
                try
                {
                    // Simulate a different type of error for demonstration purposes
                    int divisor = 0;
                    int result = 10 / divisor; // This will throw a DivideByZeroException
                }
                catch (DivideByZeroException innerEx)
                {
                    Console.WriteLine("DivideByZeroException caught inside IndexOutOfRangeException block: " + innerEx.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}







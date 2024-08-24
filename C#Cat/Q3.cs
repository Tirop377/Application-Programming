//Q3
/*
 * The CLR is the runtime environment of the .NET Framework that manages the execution of .NET programs.
 * The BCL is a vast collection of reusable classes, interfaces, and value types that provide essential
 * functionality for .NET applications.
 * The CLR manages the execution of applications, ensuring they run smoothly and safely, while the BCL 
 * offers a rich set of libraries that simplify development by providing pre-built functionality for 
 * common programming tasks. This synergy between the CLR and BCL allows developers to create high-quality
 * applications quickly and with fewer errors.
 */

//(a)

class LibraryManagementSystem
{
    // File path for storing the list of books
    private static readonly string filePath = "books.txt";

    static void Main()
    {
        // Create or overwrite the file with a list of books
        CreateFile();

        // Write additional books to the file
        WriteToFile("1984 by George Orwell");
        WriteToFile("To Kill a Mockingbird by Harper Lee");

        // Read and display the contents of the file
        ReadFile();
    }

    // Method to create a file and write initial book entries
    static void CreateFile()
    {
        string[] books = {
            "Pride and Prejudice by Jane Austen",
            "The Great Gatsby by F. Scott Fitzgerald",
            "Moby Dick by Herman Melville"
        };

        // Create the file and write the initial list of books
        File.WriteAllLines(filePath, books);

        Console.WriteLine("File created and initial list of books written.");
    }

    // Method to append a new book entry to the file
    static void WriteToFile(string book)
    {
        // Append a new book to the file
        File.AppendAllText(filePath, book + Environment.NewLine);

        Console.WriteLine($"'{book}' has been added to the list of books.");
    }

    // Method to read and display the contents of the file
    static void ReadFile()
    {
        Console.WriteLine("\nList of Books in the Library:");

        // Read all lines from the file and display them
        string[] books = File.ReadAllLines(filePath);
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
    }
}


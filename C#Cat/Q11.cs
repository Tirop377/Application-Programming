/*

Purpose of Packages in C#:
What Are Packages?

    Packages in C# are collections of compiled code (DLLs), resources, and configuration 
    files that provide specific functionalities. They can be used to extend the capabilities 
    of a .NET application without writing everything from scratch.
    NuGet is the package manager for .NET. It hosts thousands of packages that 
    developers can easily integrate into their projects.


Why Use Packages?
    Simplify Development: Packages provide pre-built solutions for common tasks, 
    allowing developers to focus on the unique aspects of their projects. 
    For example, packages like Newtonsoft.Json handle JSON serialization/deserialization, saving time and effort.
    Code Consistency: Using widely-adopted packages helps ensure consistency across projects. 
    For instance, if multiple projects use the same logging package, they will likely 
    follow a similar logging structure, making maintenance easier.
    Reduce Code Duplication: Instead of writing the same code across different projects, 
    you can use packages to share common functionality. This also makes updating the 
    functionality easier—just update the package version.


Installing and Using a NuGet Package:

    Install a Package:
        Open the Package Manager Console in Visual Studio or use the NuGet Package Manager GUI.
        To install a package via the console, use the command:
            Install-Package PackageName

*/


// a) JSON Serialization and Deserialization with Complex Nested Structures

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Complex nested JSON string
        string jsonString = @"
        {
            'Title': 'Inception',
            'Director': {
                'Name': 'Christopher Nolan',
                'Age': 50
            },
            'Cast': [
                { 'Name': 'Leonardo DiCaprio', 'Role': 'Cobb' },
                { 'Name': 'Joseph Gordon-Levitt', 'Role': 'Arthur' }
            ],
            'Genres': ['Action', 'Sci-Fi']
        }";

        // Deserialize the JSON string to a dynamic object
        dynamic movie = JsonConvert.DeserializeObject(jsonString);

        // Access nested properties
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Director: {movie.Director.Name}, Age: {movie.Director.Age}");
        
        // Access array elements
        Console.WriteLine("Cast:");
        foreach (var actor in movie.Cast)
        {
            Console.WriteLine($"  {actor.Name} as {actor.Role}");
        }

        Console.WriteLine("Genres: " + string.Join(", ", movie.Genres));

        // Modify the object
        movie.Director.Age = 51;

        // Serialize back to JSON
        string updatedJsonString = JsonConvert.SerializeObject(movie, Formatting.Indented);
        Console.WriteLine("\nUpdated JSON:");
        Console.WriteLine(updatedJsonString);
    }
}


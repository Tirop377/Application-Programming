
//News Aggregation Application Using HttpClient

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class NewsAggregator
{
    static async Task Main(string[] args)
    {
        string apiUrl = "https://newsapi.org/v2/top-headlines?country=us&apiKey=YOUR_API_KEY";
        
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                ParseAndDisplayNews(jsonResponse);
            }
            else
            {
                Console.WriteLine("Error: Unable to retrieve news data.");
            }
        }
    }

    static void ParseAndDisplayNews(string jsonResponse)
    {
        JObject newsData = JObject.Parse(jsonResponse);
        JArray articles = (JArray)newsData["articles"];

        foreach (var article in articles)
        {
            string title = article["title"]?.ToString();
            string description = article["description"]?.ToString();

            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Summary: {description}");
            Console.WriteLine(new string('-', 40));
        }
    }
}


// a) File Operations with Filtering

using System;
using System.IO;

class FileFilter
{
    static void Main(string[] args)
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        string keyword = "keyword";  // Define the keyword to filter by
        int minLength = 10;  // Define the minimum length of the line to keep

        using (StreamReader reader = new StreamReader(inputFilePath))
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Filter condition: Line contains the keyword and is longer than the minimum length
                if (line.Contains(keyword) && line.Length > minLength)
                {
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine("Filtered lines have been written to the output file.");
    }
}

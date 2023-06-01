using INQ.Inquisitor.Model;
using Newtonsoft.Json;

namespace INQ.Inquisitor.App.Searchers;

public static class BookSearcher
{
    public static async Task<List<OpenLibraryBook>> SearchBooksAsync(string query)
    {
        // Create an HttpClient instance
        using var httpClient = new HttpClient();

        // Set the base URL of the Open Library API
        string baseUrl = "http://openlibrary.org/";

        // Build the search API endpoint URL
        string apiUrl = $"{baseUrl}search.json?q={Uri.EscapeDataString(query)}";

        // Send the HTTP GET request to the API
        var response = await httpClient.GetAsync(apiUrl);

        // Ensure a successful response
        response.EnsureSuccessStatusCode();

        // Read the response content as a string
        string responseBody = await response.Content.ReadAsStringAsync();

        // Deserialize the response JSON into an object
        var searchResult = JsonConvert.DeserializeObject<OpenLibrarySearchResult>(responseBody);

        return searchResult.Docs;
    }
}


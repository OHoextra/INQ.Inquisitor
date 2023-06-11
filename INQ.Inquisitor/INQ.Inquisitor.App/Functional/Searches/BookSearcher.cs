using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace INQ.Inquisitor.App.Functional.Searchers;

public static class BookSearcher
{
    private static readonly string OpenLibraryUrl = "http://openlibrary.org/";

    public static async Task<JArray> Search_BooksAsync(string query)
    {
        using var httpClient = new HttpClient();

        var requestUrl = $"{OpenLibraryUrl}search.json?q={Uri.EscapeDataString(query)}";

        var response = await httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        dynamic searchResult = JsonConvert.DeserializeObject(responseBody);
        dynamic docs = searchResult.docs;

        return docs;
    }

    public static async Task<JObject> GetBookDetailsAsync(string identifier)
    {
        using HttpClient httpClient = new();
        var baseUrl = "http://openlibrary.org/";
        var apiUrl = $"{baseUrl}books/{identifier}.json";

        HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        dynamic bookDetails = JObject.Parse(responseBody);

        return bookDetails;
    }
}


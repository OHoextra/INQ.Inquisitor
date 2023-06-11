using Newtonsoft.Json;

namespace INQ.Inquisitor.Model.Book.OpenLibrary;

public class OpenLibraryBook
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("author_name")]
    public List<string> AuthorName { get; set; }
}


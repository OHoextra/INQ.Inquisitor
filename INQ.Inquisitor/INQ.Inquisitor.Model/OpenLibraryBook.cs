using Newtonsoft.Json;

namespace INQ.Inquisitor.Model;

public class OpenLibraryBook
{
    [JsonProperty("title")] 
    public string Title { get; set; }

    [JsonProperty("author_name")] 
    public List<string> AuthorName { get; set; }
}


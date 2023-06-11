using Newtonsoft.Json;

namespace INQ.Inquisitor.Model;

public class OpenLibrarySearchResult
{
    [JsonProperty("docs")]
    public List<OpenLibraryBook> Docs { get; set; }
}


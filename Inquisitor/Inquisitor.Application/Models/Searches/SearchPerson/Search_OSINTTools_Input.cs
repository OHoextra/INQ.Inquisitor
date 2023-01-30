namespace Inquisitor.Application.Models.Searches.SearchPerson;

public class Search_OSINTTools_Input
{
    public string? UrlMustContain { get; set; }
    public List<string> CategoriesToMatch { get; set; } = new();
}

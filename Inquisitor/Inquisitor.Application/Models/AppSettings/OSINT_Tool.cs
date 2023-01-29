namespace Inquisitor.Application.Models.AppSettings;

public class OSINT_Tool
{
    public string Url { get; set; } = string.Empty;

    public List<string> Categories { get; set; } = new();
}


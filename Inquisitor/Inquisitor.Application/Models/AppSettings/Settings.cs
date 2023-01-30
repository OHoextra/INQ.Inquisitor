namespace Inquisitor.Application.Models.AppSettings;

public class Settings
{
    public List<string> Search_Person_Urls { get; set; } = new();

    public List<OSINT_Tool> Search_OSINTTool_Urls { get; set; } = new ();
}


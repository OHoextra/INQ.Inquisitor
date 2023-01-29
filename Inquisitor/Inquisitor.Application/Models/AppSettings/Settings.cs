namespace Inquisitor.Application.Models.AppSettings;

public class Settings
{
    public string SearchPerson_Url1 { get; set; } = string.Empty;
    public string SearchPerson_Url2 { get; set; } = string.Empty;
    public string SearchPerson_Url3 { get; set; } = string.Empty;

    public List<OSINT_Tool> Tools { get; set; } = new ();
}


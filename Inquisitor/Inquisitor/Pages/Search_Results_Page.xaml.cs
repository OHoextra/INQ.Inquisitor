using Inquisitor.Controls;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Pages;

public partial class Search_Results_Page : ContentPage
{
    private readonly IConfiguration _config;
    private readonly ILogger _logger;

    public Search_Results_Page(IConfiguration config, IEnumerable<string> searchResults = null)
    {
        _config = config;
        _logger = Log.ForContext<Search_Results_Page>(); 

        
        InitializeComponent();

        if (searchResults == null) 
            return;

        var searchResultCounter = 0;
        foreach (var searchResult in searchResults)
        {
            searchResultCounter++;

            _logger.Verbose($"{nameof(searchResult)} #{searchResultCounter} > {searchResult}");

            VStackLayout.Add(new HyperlinkLabel(searchResult, searchResult));
        }
    }
}
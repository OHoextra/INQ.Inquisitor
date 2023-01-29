using Inquisitor.Controls;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Pages;

public partial class SearchResultsPage : ContentPage
{
    private readonly IConfiguration _config;
    private readonly ILogger _logger;

    public SearchResultsPage(IConfiguration config, IEnumerable<string> searchResults = null)
    {
        _config = config;
        _logger = Log.ForContext<SearchResultsPage>(); 

        
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
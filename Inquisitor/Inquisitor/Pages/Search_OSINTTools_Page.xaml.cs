using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Pages;

public partial class SearchOSINTTools : ContentPage
{
    private readonly ILogger _logger;
    private readonly IConfiguration _config;

    public SearchOSINTTools(IConfiguration config)
    {
        _config = config;
        _logger = Log.ForContext<SearchOSINTTools>(); 

        InitializeComponent();
    }

    private async void OnSearchOSINTToolsByAllFieldsSubmitted(object sender, EventArgs e)
        => await Navigation.PushAsync(new SearchResultsPage(_config));

    private async void OnBackClicked(object sender, EventArgs e) 
        => await Navigation.PopAsync();
}
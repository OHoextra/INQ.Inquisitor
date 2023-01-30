using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Pages;

public partial class Search_OSINTTools_Page : ContentPage
{
    private readonly ILogger _logger;
    private readonly IConfiguration _config;

    public Search_OSINTTools_Page(IConfiguration config)
    {
        _config = config;
        _logger = Log.ForContext<Search_OSINTTools_Page>(); 

        InitializeComponent();
    }

    private async void OnSearchOSINTToolsByAllFieldsSubmitted(object sender, EventArgs e)
        => await Navigation.PushAsync(new Search_Results_Page(_config));

    private async void OnBackClicked(object sender, EventArgs e) 
        => await Navigation.PopAsync();
}
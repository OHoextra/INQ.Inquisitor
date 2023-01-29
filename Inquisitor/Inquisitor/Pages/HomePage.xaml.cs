using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Pages;

public partial class HomePage : ContentPage
{
    private readonly IConfiguration _config;
    private readonly ILogger _logger;

    public HomePage(IConfiguration config)
	{
        _config = config;
        _logger = Log.ForContext<HomePage>(); 

        InitializeComponent();
	}

    private async void OnSearchPersonClicked(object sender, EventArgs e) 
        => await Navigation.PushAsync(new SearchPersonPage(_config));

    private async void OnSearcOSINTToolsClicked(object sender, EventArgs e)
        => await Navigation.PushAsync(new SearchOSINTTools(_config));
}


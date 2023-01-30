using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Pages;

public partial class Home_Page : ContentPage
{
    private readonly IConfiguration _config;
    private readonly ILogger _logger;

    public Home_Page(IConfiguration config)
	{
        _config = config;
        _logger = Log.ForContext<Home_Page>(); 

        InitializeComponent();
	}

    private async void OnSearchPersonClicked(object sender, EventArgs e) 
        => await Navigation.PushAsync(new Search_Person_Page(_config));

    private async void OnSearchOSINTToolsClicked(object sender, EventArgs e)
        => await Navigation.PushAsync(new Search_OSINTTools_Page(_config));
}


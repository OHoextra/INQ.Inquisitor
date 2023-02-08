using Microsoft.Extensions.Configuration;

namespace INQ.Inquisitor.App.Pages;

public partial class Example_Home_Page : ContentPage
{
    private readonly IConfiguration _config;

    public Example_Home_Page(IConfiguration config)
	{
        _config = config;
    }


    private async void OnSearchOSINTToolsClicked(object sender, EventArgs e)
        => await Navigation.PushAsync(new Example_Sub_Page(_config));
}


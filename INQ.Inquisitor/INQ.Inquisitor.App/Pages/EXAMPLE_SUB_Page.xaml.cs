using Microsoft.Extensions.Configuration;

namespace INQ.Inquisitor.App.Pages;

public partial class Example_Sub_Page : ContentPage
{
    private readonly IConfiguration _config;

    public Example_Sub_Page(IConfiguration config)
    {
        _config = config;
    }

    private async void OnBackClicked(object sender, EventArgs e) 
        => await Navigation.PopAsync();
}
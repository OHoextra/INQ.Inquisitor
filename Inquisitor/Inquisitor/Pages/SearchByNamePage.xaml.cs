namespace Inquisitor.Pages;

public partial class SearchByNamePage : ContentPage
{
    private readonly List<string> _webAddresses = new()
    {
        "https://olafhoekstra.nl" , "https://cutt.ly/Manifestations"
    };

    public SearchByNamePage()
	{
		InitializeComponent();
    }

    private async void OnSearchByFirstNameSubmitted(object sender, EventArgs e)
    {
        var searchResults = _webAddresses.Where(c => c.Contains(FirstNameSearchBar.Text ?? ""));

        await Navigation.PushAsync(new SearchResultsPage(searchResults));
    }

    private async void OnSearchByLastNameSubmitted(object sender, EventArgs e)
    {
        var searchResults = _webAddresses.Where(c => c.Contains(LastNameSearchBar.Text ?? ""));

        await Navigation.PushAsync(new SearchResultsPage(searchResults));
    }

    private async void OnSearchByFirstAndLastNameSubmitted(object sender, EventArgs e)
    {
        var firstName = FirstNameSearchBar.Text ?? "";
        var lastName = LastNameSearchBar.Text ?? "";

        var searchResults = _webAddresses.Where(c => c.Contains(lastName) || c.Contains(firstName));

        await Navigation.PushAsync(new SearchResultsPage(searchResults));
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
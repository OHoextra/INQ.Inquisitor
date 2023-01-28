namespace Inquisitor.Pages;

public partial class SearchByNamePage : ContentPage
{
	public SearchByNamePage()
	{
		InitializeComponent();
	}

    private async void OnSearchByNameSubmitted(object sender, EventArgs e)
        => await Navigation.PushAsync(new SearchResultsPage());

    private async void OnBackClicked(object sender, EventArgs e) 
        => await Navigation.PopAsync();
}
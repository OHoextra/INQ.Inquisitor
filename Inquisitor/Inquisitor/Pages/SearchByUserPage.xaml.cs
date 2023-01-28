namespace Inquisitor.Pages;

public partial class SearchByUserPage : ContentPage
{
	public SearchByUserPage()
	{
		InitializeComponent();
	}

    private async void OnSearchByUserSubmitted(object sender, EventArgs e)
        => await Navigation.PushAsync(new SearchResultsPage());

    private async void OnBackClicked(object sender, EventArgs e) 
        => await Navigation.PopAsync();
}
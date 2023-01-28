namespace Inquisitor.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
	{
		InitializeComponent();
	}

    private async void OnSearchByNameClicked(object sender, EventArgs e) 
        => await Navigation.PushAsync(new SearchByNamePage());

    private async void OnSearchByUserClicked(object sender, EventArgs e)
        => await Navigation.PushAsync(new SearchByUserPage());
}


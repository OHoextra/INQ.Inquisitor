using System.Windows.Input;

namespace Inquisitor.Pages;

public partial class SearchResultsPage : ContentPage
{
	public SearchResultsPage()
	{
		InitializeComponent();
	}

    public ICommand OpenLinkCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
}
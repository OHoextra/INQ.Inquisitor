using Inquisitor.Controls;

namespace Inquisitor.Pages;

public partial class SearchResultsPage : ContentPage
{
	public SearchResultsPage(IEnumerable<string> searchResults = null)
	{
		InitializeComponent();

        if (searchResults == null) 
            return;

        foreach (var searchResult in searchResults)
        {
            VStackLayout.Add(new HyperlinkLabel(searchResult, searchResult));
        }
    }
}
using Inquisitor.Application.Models;
using Inquisitor.Application.Models.Searches.SearchPerson;
using Inquisitor.Application.Models.Searches.Variables;
using Microsoft.Extensions.Configuration;
using Serilog;
using ILogger = Serilog.ILogger;
using JsonSerializer = Inquisitor.Application.Utils.JsonSerializer;

namespace Inquisitor.Pages;

public partial class SearchPersonPage : ContentPage
{
    private readonly List<string> _fakeSearchSources = new();

    private readonly IConfiguration _config;
    private readonly ILogger _logger;

    public SearchPersonPage(IConfiguration config)
    {
        _config = config;
        _logger = Log.ForContext<SearchPersonPage>();

        InitializeComponent();
    }

    private void OnSearchByFirstNameSubmitted(object sender, EventArgs e) 
        => Application.Inquisitor.SearchPerson(new Search_Person_Input{Firstname = FirstNameSearchBar.Text}
           );


    private void OnSearchByLastNameSubmitted(object sender, EventArgs e)
        => Application.Inquisitor.SearchStringsByStrings(
            _fakeSearchSources,
            new SearchString
            {
                ComponentName = $"{nameof(LastNameSearchBar)}",
                Value = FirstNameSearchBar.Text ?? ""
            });

    private void OnSearchByUserSubmitted(object sender, EventArgs e)
        => Application.Inquisitor.SearchStringsByStrings(
            _fakeSearchSources,
            new SearchString
            {
                ComponentName = $"{nameof(UsernameSearchBar)}",
                Value = UsernameSearchBar.Text ?? ""
            });

    private void OnSearchByAllFieldsSubmitted(object sender, EventArgs e)
        => Application.Inquisitor.SearchStringsByStrings(
            _fakeSearchSources,
            new SearchString
            {
                ComponentName = $"{nameof(FirstNameSearchBar)}",
                Value = FirstNameSearchBar.Text ?? ""
            },
            new SearchString
            {
                ComponentName = $"{nameof(LastNameSearchBar)}",
                Value = LastNameSearchBar.Text ?? ""
            },
            new SearchString
            {
                ComponentName = $"{nameof(UsernameSearchBar)}",
                Value = UsernameSearchBar.Text ?? ""
            });

    private async void OnBackClicked(object sender, EventArgs e) 
        => await Navigation.PopAsync();
}
using Inquisitor.Application.Models.AppSettings;
using Inquisitor.Application.Models.Searches.SearchPerson;
using Inquisitor.Application.Utils;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Inquisitor.Application
{
    public class Searcher
    {
        private readonly ILogger _logger = Log.ForContext(typeof(Searcher));

        private readonly List<string> _searchPersonUrls = new();
        private readonly List<string> _searchOSINTToolsUrls = new();

        public Searcher(IConfiguration config)
        {
            var settings = config.GetRequiredSection(nameof(Settings)).Get<Settings>();
            if (settings == null)
                throw new InvalidOperationException($"{nameof(settings)} == null");

            _searchPersonUrls.Add(settings.SearchPerson_Url1);
            _searchPersonUrls.Add(settings.SearchPerson_Url2);
            _searchPersonUrls.Add(settings.SearchPerson_Url3);
        }

        public SearchPersonOutput Search_OSINTTools(SearchPersonInput input)
        {
            _logger.Debug($"{nameof(Search_OSINTTools)}>{nameof(_searchOSINTToolsUrls)} to filter by search:{Environment.NewLine}{JsonSerializer.Serialize(_searchOSINTToolsUrls)}");
            _logger.Debug($"{nameof(Search_OSINTTools)}>{nameof(input)}:{Environment.NewLine}{JsonSerializer.Serialize(input)}");

            var output = new SearchPersonOutput
            {
                UrlsRelatedToPerson = SearchFromStringsByAnyContainsAnyStrings(
                    _searchPersonUrls,
                    input.Firstname,
                    input.Lastname,
                    input.Username)
            };

            _logger.Debug($"{nameof(Search_Person)}>{nameof(output)}:{Environment.NewLine}{JsonSerializer.Serialize(output)}");

            return output;
        }

        public SearchPersonOutput Search_Person(SearchPersonInput input)
        {
            _logger.Debug($"{nameof(Search_Person)}>{nameof(_searchPersonUrls)} to filter by search:{Environment.NewLine}{JsonSerializer.Serialize(_searchPersonUrls)}");
            _logger.Debug($"{nameof(Search_Person)}>{nameof(input)}:{Environment.NewLine}{JsonSerializer.Serialize(input)}");

            var output = new SearchPersonOutput
            {
                UrlsRelatedToPerson = SearchFromStringsByAnyContainsAnyStrings(
                    _searchPersonUrls,
                    input.Firstname,
                    input.Lastname,
                    input.Username)
            };

            _logger.Debug($"{nameof(Search_Person)}>{nameof(output)}:{Environment.NewLine}{JsonSerializer.Serialize(output)}");

            return output;
        }

        private static List<string> SearchFromStringsByAnyContainsAnyStrings(
            IReadOnlyCollection<string> searchFromList, 
            params string[] searchByStrings)
        {
            var searchResults = new List<string>();
            foreach (var searchByString in searchByStrings)
            {
                if (string.IsNullOrWhiteSpace(searchByString))
                    continue;

                searchResults.AddRange(searchFromList.Where(c => c.Contains(searchByString)));

                searchResults = searchResults.Distinct().ToList();
            }

            return searchResults;
        }
    }
}
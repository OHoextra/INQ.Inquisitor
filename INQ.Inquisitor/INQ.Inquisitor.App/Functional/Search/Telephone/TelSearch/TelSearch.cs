using TelSearchApi;

namespace INQ.Inquisitor.App.Functional.Search.Telephone.TelSearch;

public static class TelSearch
{
    /// <summary>
    /// Does not seem to match or know Dutch telephone numbers? Only Hungarian?
    /// </summary>
    public static async Task<TelSearchQueryResponse> Search_PhoneNumber(string phoneNumber, string language = "NL")
    {
        // https://tel.search.ch/api/help.en.html
        // https://github.com/psollberger/TelSearchApi
        var client = new TelSearchClient("be8e45356f57a7a3c6777470a0a65bb1");
        var lookupRequest = new TelSearchQuery(client)
        {
            Query = phoneNumber,
            Language = language
        };

        return await lookupRequest.ExecuteAsync();
    }
}


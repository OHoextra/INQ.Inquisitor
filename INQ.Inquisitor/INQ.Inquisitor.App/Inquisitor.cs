using LinqToTwitter;
using LinqToTwitter.OAuth;
using NewsAPI;
using NewsAPI.Entities;
using NewsAPI.Entities.Enums;
using PixabaySharp;
using PixabaySharp.Enums;
using PixabaySharp.Utility;
using TelSearchApi;
using ImageItem = PixabaySharp.Models.ImageItem;

namespace INQ.Inquisitor.App;

public static class Inquisitor
{
    public static async Task<List<ImageItem>> SearchImages(
        string query,
        Order order = Order.Popular,
        PixabaySharp.Enums.Language language = PixabaySharp.Enums.Language.EN,
        ImageType imageType = ImageType.All,
        Orientation orientation = Orientation.All,
        int minWidth = 800,
        int minHeight = 600)
    {
        var client = new PixabaySharpClient("36106784-3d9d1cbca4b570a7d51e8287b");

        var result = await client.QueryImagesAsync(
            new ImageQueryBuilder
            {
                Query = query,
                Language = language,
                Order = order,
                ImageType = imageType,
                Orientation = orientation,
                MinWidth = minWidth,
                MinHeight = minHeight,
                Page = 1,
                PerPage = 6
            });

        return result.Images.ToList();
    }

    /// <summary>
    /// Does not seem to match or know Dutch telephone numbers?
    /// </summary>
    public static async Task<TelSearchQueryResponse> LookupPhoneNumber(
        string query,
        string language = "NL")
    {
        // https://tel.search.ch/api/help.en.html
        // https://github.com/psollberger/TelSearchApi
        var client = new TelSearchClient("be8e45356f57a7a3c6777470a0a65bb1");
        var lookupRequest = new TelSearchQuery(client)
        {
            Query = query,
            Language = language
        };

       return await lookupRequest.ExecuteAsync();
    }

    public static async Task<List<NewsArticle>> SearchNewsArticles(
        string query,
        SortType sortType = SortType.Relevancy,
        DateTime? dateFrom = null,
        DateTime? dateTo = null)
    {
        var newsClient = new NewsClient("987ff64405e64b2fa3a55a84f2334e4c");

        dateTo ??= DateTime.Now;
        dateFrom ??= dateTo.Value.AddDays(-3);

        var newsResult =
            await newsClient.FetchNewsAsync(new AllNewsRequest(query, sortType, dateFrom.Value, dateTo.Value));

        return newsResult.ResponseStatus == ResponseStatus.Ok
            ? newsResult.Articles.ToList() // TODO: are we fitlering out all results?
            : new List<NewsArticle>();
    }

}

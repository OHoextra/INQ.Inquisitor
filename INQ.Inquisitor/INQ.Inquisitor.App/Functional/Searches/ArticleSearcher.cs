using NewsAPI;
using NewsAPI.Entities;
using NewsAPI.Entities.Enums;

namespace INQ.Inquisitor.App.Functional.Searchers;

public static class ArticleSearcher
{
    public static async Task<List<NewsArticle>> Search_Articles(
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
            ? newsResult.Articles.ToList()
            : new List<NewsArticle>();
    }
}


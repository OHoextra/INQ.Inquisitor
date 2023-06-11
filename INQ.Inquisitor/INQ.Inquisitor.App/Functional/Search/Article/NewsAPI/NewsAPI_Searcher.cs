using INQ.Inquisitor.Model.Article;
using NewsAPI;
using NewsAPI.Entities;
using NewsAPI.Entities.Enums;

namespace INQ.Inquisitor.App.Functional.Search.Article.NewsAPI;

public static class NewsAPI_Searcher
{
    private static readonly string NewsAPI_APIKey = "987ff64405e64b2fa3a55a84f2334e4c";

    public static async Task<ArticleSearchAnswer> SearchArticles(ArticleSearchQuestion question)
    {
        var newsClient = new NewsClient(NewsAPI_APIKey);

        if (string.IsNullOrWhiteSpace(question.QuestionText))
            throw new ArgumentException(nameof(question.QuestionText));

        question.From ??= DateTime.Now.AddDays(-3);
        question.To ??= DateTime.Now;

        var newsResult = await newsClient.FetchNewsAsync(
            new AllNewsRequest(
                question.QuestionText,
                question.SortType,
                question.From.Value,
                question.To.Value));

        return newsResult.ResponseStatus == ResponseStatus.Ok
            ? new ArticleSearchAnswer { Articles = newsResult.Articles.ToList() }
            : new ArticleSearchAnswer();
    }
}


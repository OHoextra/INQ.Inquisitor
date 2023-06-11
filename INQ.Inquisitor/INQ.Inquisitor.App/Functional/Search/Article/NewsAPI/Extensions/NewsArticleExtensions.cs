using NewsAPI.Entities;

namespace INQ.Inquisitor.App.Functional.Search.Article.NewsAPI.Extensions;

public static class NewsArticleExtensions
{
    public static IEnumerable<NewsArticle> WhereContainsQuery(this IEnumerable<NewsArticle> inputArticles, string query)
    {
        var inputArticlesList = inputArticles.ToList();
        var outputArticlesList = new List<NewsArticle>();

        outputArticlesList.AddRange(inputArticlesList
            .Where(x => !string.IsNullOrWhiteSpace(x.Url))
            .Where(x => x.Url.Contains(query) && !outputArticlesList.Contains(x)));

        outputArticlesList.AddRange(inputArticlesList
            .Where(x => !string.IsNullOrWhiteSpace(x.Author))
            .Where(x => x.Author.Contains(query) && !outputArticlesList.Contains(x)));

        outputArticlesList.AddRange(inputArticlesList
            .Where(x => !string.IsNullOrWhiteSpace(x.Title))
            .Where(x => x.Title.Contains(query) && !outputArticlesList.Contains(x)));

        outputArticlesList.AddRange(inputArticlesList
            .Where(x => !string.IsNullOrWhiteSpace(x.Description))
            .Where(x => x.Description.Contains(query) && !outputArticlesList.Contains(x)));

        outputArticlesList.AddRange(inputArticlesList
            .Where(x => !string.IsNullOrWhiteSpace(x.Source.Name))
            .Where(x => x.Source.Name.Contains(query) && !outputArticlesList.Contains(x)));

        return outputArticlesList;
    }

    public static string ToText(this List<NewsArticle> articles)
    {
        var output = "";
        if (articles.Any())
        {
            foreach (var article in articles)
            {
                output = string.IsNullOrWhiteSpace(output)
                    ? article.ToText()
                    : output + Environment.NewLine + Environment.NewLine + Environment.NewLine + article.ToText();
            }
        }

        return output;
    }

    public static string ToText(this NewsArticle article)
    {
        var output = article.Title + Environment.NewLine + Environment.NewLine;
        if (!string.IsNullOrWhiteSpace(article.Author))
        {
            output += "Author: " + article.Author;
        }

        if (article.PublishedAt != default)
        {
            output += " - " + article.PublishedAt;
        }

        output += Environment.NewLine + Environment.NewLine + article.Description;
        output += Environment.NewLine + Environment.NewLine + "(Source:" + article.Url + ")";

        return output;
    }
}


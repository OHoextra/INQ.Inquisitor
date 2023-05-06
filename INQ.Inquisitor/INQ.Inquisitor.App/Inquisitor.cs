using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

namespace INQ.Inquisitor.App
{
    public static class Inquisitor
    {
        public static string SearchNews(string query, SortBys sortBy = SortBys.Relevancy, Languages language = Languages.EN, DateTime? from = null)
        {
            var output = "";

            var newsApiClient = new NewsApiClient("987ff64405e64b2fa3a55a84f2334e4c");
            from ??= DateTime.Now.AddDays(-3);
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = query,
                SortBy = sortBy,
                Language = language,
                From = from
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                if (articlesResponse.Articles.Any())
                {
                    var articleIndex = 0;
                    foreach (var article in articlesResponse.Articles)
                    {
                        articleIndex++;

                        // TODO: add article extension ToText

                        output = string.IsNullOrWhiteSpace(output) 
                            ? "Article #1 - " + article.Title

                        // title
                        Console.WriteLine(article.Title);
                        // author
                        Console.WriteLine(article.Author);
                        // description
                        Console.WriteLine(article.Description);
                        // url
                        Console.WriteLine(article.Url);
                        // published at
                        Console.WriteLine(article.PublishedAt);
                    }
                }

              
            }
            Console.ReadLine();
        }
    }
}
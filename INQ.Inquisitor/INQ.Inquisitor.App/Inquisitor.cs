using System.Net.Mime;
using INQ.Inquisitor.Model.ContentTypes;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Entities;
using NewsAPI.Entities.Enums;
using PixabaySharp;
using PixabaySharp.Enums;
using PixabaySharp.Utility;

namespace INQ.Inquisitor.App
{
    public static class Inquisitor
    {
        public static async Task<Image> SearchStockImages(string query, ImageType imageType = ImageType.All, Order order = Order.Latest)
        {
            var client = new PixabaySharpClient("36106784-3d9d1cbca4b570a7d51e8287b");

            var result = await client.QueryImagesAsync(
                new ImageQueryBuilder
            {
                Query = query,
                Language = ,
                MinWidth = ,
                MinHeight = ,
                Order = order,
                ImageType = imageType,
                Orientation = ,
                Page = 2,
                PerPage = 5
            });

            result.

        }


        public static async Task<string[]> SearchNewsTexts(string query, SortType sortType = SortType.Relevancy, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var output = "";

            var newsClient = new NewsClient("987ff64405e64b2fa3a55a84f2334e4c");
            dateTo ??= DateTime.Now;
            dateFrom ??= dateTo.Value.AddDays(-3);

            var newsResult = await newsClient.FetchNewsAsync(new AllNewsRequest(query, sortType, dateFrom.Value, dateTo.Value));

            if (newsResult.ResponseStatus != ResponseStatus.Ok)
            {
                if (newsResult.Articles.Any())
                {
                    var articleIndex = 0;
                    foreach (var article in newsResult.Articles)
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
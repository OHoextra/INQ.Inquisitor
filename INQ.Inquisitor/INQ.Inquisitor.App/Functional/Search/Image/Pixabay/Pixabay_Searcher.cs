using PixabaySharp;
using PixabaySharp.Enums;
using PixabaySharp.Models;
using PixabaySharp.Utility;

namespace INQ.Inquisitor.App.Functional.Search.Image.Pixabay;

public static class Pixabay_Searcher
{
    public static async Task<List<ImageItem>> SearchImages(
        string query,
        Order order = Order.Popular,
        Language language = Language.EN,
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
}

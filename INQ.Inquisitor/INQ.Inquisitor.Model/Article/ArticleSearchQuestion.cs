using INQ.Inquisitor.Model.Base;
using NewsAPI.Entities.Enums;

namespace INQ.Inquisitor.Model.Article;

public class ArticleSearchQuestion : BaseQuestion
{
    // TODO: replace with enum internal to inquisitor
    public SortType SortType { get; set; } = SortType.Relevancy;
    public DateTime? From { get; set; } = null;
    public DateTime? To { get; set; } = null;
}

// TODO: add other questions and answers
// TODO: fix something with nuget packages
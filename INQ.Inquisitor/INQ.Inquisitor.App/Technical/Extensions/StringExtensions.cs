namespace INQ.Inquisitor.App.Extensions;

public static class StringExtensions
{
    public static IEnumerable<string> WhereNot_NullOrWhiteSpace(this IEnumerable<string> stringCollection)
        => stringCollection.Where(str => !string.IsNullOrWhiteSpace(str));
}


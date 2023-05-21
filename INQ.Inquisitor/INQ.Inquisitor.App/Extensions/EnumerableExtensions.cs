using INQ.Inquisitor.App.Exceptions;

namespace INQ.Inquisitor.App.Extensions;

public static class EnumerableExtensions
{
    public static void ThrowOnDefault<TType>(
        this IEnumerable<TType> collection)
    {
        if (collection == default)
            throw new ArgumentDefaultException(nameof(collection));
    }

    public static void ThrowOnEmpty<TType>(
        this IEnumerable<TType> collection)
    {
        if (collection == default)
            throw new ArgumentDefaultException(nameof(collection));

        var typesList = collection.ToList();
        if (!typesList.Any())
            throw new ArgumentEmptyException(nameof(collection));
    }
}

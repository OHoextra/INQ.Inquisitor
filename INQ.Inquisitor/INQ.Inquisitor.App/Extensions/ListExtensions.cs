namespace INQ.Inquisitor.App.Extensions;

public static class ListExtensions
{
    public static void RemoveRange<TType>(
        this List<TType> totalItems,
        IEnumerable<TType> itemsToRemove)
    {
        foreach (var exclusionType in itemsToRemove)
        {
            totalItems.Remove(exclusionType);
        }
    }

    public static void AddDistinctly<TType>(
        this List<TType> totalItems,
        TType itemsToAdd)
    {
        if (!totalItems.Contains(itemsToAdd))
            totalItems.Add(itemsToAdd);
    }

    public static void AddRangeDistinctly<TType>(
        this List<TType> totalItems,
        IEnumerable<TType> itemsToAdd)
    {
        totalItems.AddRange(
            itemsToAdd.Where(
                itemToAdd => !totalItems.Contains(itemToAdd)));
    }
}


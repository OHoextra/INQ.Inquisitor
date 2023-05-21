namespace INQ.Inquisitor.Console.Spectre;

public class IndexedItem<TType>
{
    public int Index { get; }
    public TType Item { get; }

    public IndexedItem(int index, TType item)
    {
        Index = index;
        Item = item;
    }

    public override string ToString()
    {
        return Item?.ToString() ?? string.Empty;
    }
}

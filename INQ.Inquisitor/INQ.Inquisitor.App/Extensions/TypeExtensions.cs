using INQ.Inquisitor.App.Exceptions;

namespace INQ.Inquisitor.App.Extensions;

public static class TypeExtensions
{
    public static List<Type> Where_Namespace_Contains(
        this List<Type> sourceTypes, 
        string nameSpacePart)
    {
        if (sourceTypes == default)
            throw new ArgumentDefaultException(nameof(sourceTypes));

        if (!sourceTypes.Any())
            throw new ArgumentEmptyException(nameof(sourceTypes));

        return string.IsNullOrWhiteSpace(nameSpacePart) 
            ? sourceTypes
            : sourceTypes.Where(type => !string.IsNullOrWhiteSpace(type.Namespace)
                                        && type.Namespace.Contains(nameSpacePart)).ToList();
    }

    public static List<Type> Where_Namespace_ContainsAny(
        this List<Type> sourceTypes,
        List<string> nameSpaceParts)
    {
        if (sourceTypes == default)
            throw new ArgumentDefaultException(nameof(sourceTypes));

        if (!sourceTypes.Any())
            throw new ArgumentEmptyException(nameof(sourceTypes));

        var resultingTypesList = new List<Type>();
        var nameSpacePartsList = nameSpaceParts.WhereNot_NullOrWhiteSpace().Distinct().ToList();
        if (nameSpacePartsList.Any())
        {
            foreach (var nameSpacePart in nameSpacePartsList)
            {
                resultingTypesList.AddRangeDistinctly(sourceTypes.Where_Namespace_Contains(nameSpacePart));
            }
        }
        else
        {
            resultingTypesList.AddRangeDistinctly(sourceTypes);
        }

        return resultingTypesList;
    }
}


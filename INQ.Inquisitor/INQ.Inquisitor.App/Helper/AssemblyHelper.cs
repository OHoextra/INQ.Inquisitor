using System.Reflection;
using INQ.Inquisitor.App.Extensions;
using Type = System.Type;

namespace INQ.Inquisitor.App.Helper;

public static class AssemblyHelper
{
    private static readonly Assembly Assembly;

    static AssemblyHelper()
    {
        var assemblyName = typeof(AssemblyHelper).Assembly.FullName;
        if (string.IsNullOrWhiteSpace(assemblyName))
            throw new InvalidOperationException($"{nameof(assemblyName)} can not be null or whitespace.");

        Assembly = Assembly.Load(assemblyName);
    }
    
    public static List<Type> LoadTypesInNamespace(string nameSpace = null)
    {
        var types = Assembly.GetTypes().ToList();

        return string.IsNullOrWhiteSpace(nameSpace)
            ? types
            : types.Where_Namespace_Contains(nameSpace);
    }

    public static List<Type> LoadTypesInNamespaces(IEnumerable<string>? nameSpaces = null)
    {
        var types = Assembly.GetTypes().ToList();

        var nameSpaceList = nameSpaces?.ToList();

        return nameSpaceList?.Any() == true
            ? types.Where_Namespace_ContainsAny(nameSpaceList)
            : types;
    }
}


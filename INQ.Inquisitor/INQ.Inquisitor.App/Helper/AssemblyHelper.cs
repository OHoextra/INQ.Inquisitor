using System.Reflection;
using INQ.Inquisitor.App.Extensions;
using Type = System.Type;

namespace INQ.Inquisitor.App.Helper;

public class AssemblyHelper
{
    private readonly Assembly _assembly;

    public AssemblyHelper(string? assemblyName = null)
    {
        if (string.IsNullOrWhiteSpace(assemblyName))
            assemblyName = typeof(AssemblyHelper).Assembly.FullName;

        if (string.IsNullOrWhiteSpace(assemblyName))
            throw new InvalidOperationException(nameof(assemblyName) + " may not be null or whitespace.");

        _assembly = Assembly.Load(assemblyName);
    }

    public List<Type> ClassesInNamespaces(IEnumerable<string>? nameSpaces = null)
    {
        var types = _assembly.GetPublicClasses().ToList();

        var nameSpaceList = nameSpaces?.ToList();

        return nameSpaceList?.Any() == true
            ? types.Where_Namespace_ContainsAny(nameSpaceList)
            : types;
    }
}


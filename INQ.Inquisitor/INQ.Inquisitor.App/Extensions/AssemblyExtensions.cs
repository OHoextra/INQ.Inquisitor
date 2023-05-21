using System.Reflection;

namespace INQ.Inquisitor.App.Extensions;

public static class AssemblyExtensions
{
    public static IEnumerable<Type> GetPublicClasses(this Assembly assembly)
        => assembly.GetTypes().Where(type => type is { IsPublic: true, IsClass: true });
}

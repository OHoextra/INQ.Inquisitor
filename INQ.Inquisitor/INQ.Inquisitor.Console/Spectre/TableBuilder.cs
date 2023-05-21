using INQ.Inquisitor.App.Exceptions;
using Spectre.Console;
using System.Reflection;

namespace INQ.Inquisitor.Console.Spectre;

public static class TableBuilder
{
    public static Table FunctionTableFromTypes(IEnumerable<Type> types)
    {
        if (types == default)
            throw new ArgumentDefaultException(nameof(types));

        var typesList = types.ToList();
        if (!typesList.Any())
            throw new ArgumentEmptyException(nameof(types));

        var table = new Table()
            .AddColumn("Assembly")
            .AddColumn("Namespace")
            .AddColumn("Class")
            .AddColumn("Function");

        foreach (var type in typesList)
        {
            var typeMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (var typeMethod in typeMethods)
            {
                table.AddRow(type.Assembly.GetName().Name ?? "EMPTY", type.Namespace ?? "EMPTY", type.Name, typeMethod.Name);
            }
        }

        return table;
    }
}


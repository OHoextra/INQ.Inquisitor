// Render a simple table with headers and rows

using System.Runtime.CompilerServices;
using Spectre.Console;
using INQ.Inquisitor.App.Helper;
using INQ.Inquisitor.Console.Spectre;


var searcherTypes = AssemblyHelper.LoadTypesInNamespace("App.Searchers");
var searcherTable = TableBuilder.FunctionTableFromTypes(searcherTypes)
    .Border(TableBorder.Rounded)
    .BorderColor(Color.Green)
    .Title(new TableTitle("App.Searchers"));

var lookupTypes = AssemblyHelper.LoadTypesInNamespace("App.Lookups");
var lookupTable = TableBuilder.FunctionTableFromTypes(searcherTypes)
    .Border(TableBorder.Rounded)
    .BorderColor(Color.Green)
    .Title(new TableTitle("App.Lookups"));


AnsiConsole.Write(searcherTable);
AnsiConsole.Write(lookupTable);

// TODO: add function numbering to the 'functionTable' class and include an Ask prompt, see if Spectre has existing implementation for this

// Ask for user input
var name = AnsiConsole.Ask<string>("What function would you like to use?");
AnsiConsole.MarkupLine($"Hello, [green]{name}[/]!");
// Output colored text
AnsiConsole.MarkupLine("[bold underline yellow]This[/] is [red]some[/] [blue]colored[/] text!");

Console.ReadLine();

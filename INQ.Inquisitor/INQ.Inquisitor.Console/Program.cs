using INQ.Inquisitor.App.Extensions;
using Spectre.Console;
using INQ.Inquisitor.App.Helper;
using INQ.Inquisitor.Console.Spectre;

var spectreHelper = new SpectreHelper(Color.Black, Color.Green);

var types = AssemblyHelper.LoadTypesInNamespaces(new[] { "App.Searchers", "App.Lookups" });

AnsiConsole.Write(spectreHelper.Table.CreateFunctionTable(types));

var typeNames = types.Select(type => type.Name);
var typeNameSelection = AnsiConsole.Prompt(spectreHelper.SelectionPrompt.Build("What class would you like to use?", typeNames));

var typeMethods = types.Single(type => type.Name == typeNameSelection).GetPublicMethods();
var typeMethodsNames = typeMethods.Select(method => method.Name);
var typeMethodsSelection = AnsiConsole.Prompt(spectreHelper.SelectionPrompt.Build("What method would you like to use?", typeMethodsNames));

AnsiConsole.MarkupLine($"You have selected: [green]{typeMethodsSelection}[/]!");

Console.ReadLine();

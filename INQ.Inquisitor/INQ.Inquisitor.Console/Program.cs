using INQ.Inquisitor.App.Extensions;
using Spectre.Console;
using INQ.Inquisitor.App.Helper;
using INQ.Inquisitor.Console.Spectre.Helpers;

var spectreHelper = new SpectreHelper(Color.Black, Color.Green);
var assemblyHelper = new AssemblyHelper();

var types = assemblyHelper.ClassesInNamespaces(new[] { "App.Searchers", "App.Lookups" });

spectreHelper.Table.DisplayClassFunctionsTable(types);

var classNames = types.Select(type => type.Name);
var classNameSelection = spectreHelper.SelectionPrompt.DisplaySelectionPrompt("What class would you like to use?", classNames);

var methods = types.Single(type => type.Name == classNameSelection).GetPublicMethods();
var methodNames = methods.Select(method => method.Name);
var methodNameSelection = spectreHelper.SelectionPrompt.DisplaySelectionPrompt("What method would you like to use?", methodNames);

// TODO: Test IRenderable.Tree

// TODO: implement prompts for method params
AnsiConsole.MarkupLine($"You have selected: [green] {classNameSelection}.{methodNameSelection}[/]!");

Console.ReadLine();

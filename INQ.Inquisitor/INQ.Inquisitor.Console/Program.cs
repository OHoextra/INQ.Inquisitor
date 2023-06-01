using INQ.Inquisitor.App.Extensions;
using Spectre.Console;
using INQ.Inquisitor.App.Helper;
using INQ.Inquisitor.Console.Spectre.Helpers;

var spectreHelper = new SpectreHelper(Color.Black, Color.Green);
var assemblyHelper = new AssemblyHelper();

var types = assemblyHelper.ClassesInNamespaces(new[] { "App.Searchers", "App.Lookups" });

spectreHelper.Table.DisplayClassFunctionsTable(types);
AnsiConsole.Clear();


var classNames = types.Select(type => type.Name);
var classNameSelection = spectreHelper.SelectionPrompt.PromptClassName(classNames);
AnsiConsole.Write("Class: " + classNameSelection);

var methods = types.Single(type => type.Name == classNameSelection).GetPublicMethods().ToList();
var methodNames = methods.Select(method => method.Name);
var methodNameSelection = spectreHelper.SelectionPrompt.PromptMethodName(methodNames);
AnsiConsole.Write("Function: " + methodNameSelection);

var selectedMethod = methods.Single(method => method.Name == methodNameSelection);

AnsiConsole.MarkupLine($"You have selected: [green] {classNameSelection}.{methodNameSelection}[/]!");

var parameters = selectedMethod.GetParameters();
// TODO provide a table overview of all parameters and according data types

spectreHelper.Table.DisplayParametersTable(parameters);

var parameterValues = spectreHelper.PromptForParameters(parameters);

var result = await selectedMethod.RunMethodAsync(parameterValues);

spectreHelper.DisplayObject(result);

// TODO: Test IRenderable.Tree
// TODO: https://spectreconsole.net/prompts/text

// TODO: implement prompts for method params


Console.ReadLine();
using INQ.Inquisitor.App.Extensions;
using INQ.Inquisitor.App.Technical.Helper;
using Spectre.Console;
using INQ.Inquisitor.Console.Spectre.Helpers;

var spectreHelper = new SpectreHelper(Color.Black, Color.Green);
var assemblyHelper = new AssemblyHelper();

spectreHelper.WriteStyled($"Welcome to Inquisitor..", Color.Pink1);

var classes = assemblyHelper.ClassesInNamespaces(new[] { "App.Functional" });

var classNameSelection = spectreHelper.Prompt.ClassName(classes);
spectreHelper.WriteStyled($"Class: {classNameSelection}", Color.Blue);

var functions = classes.GetByName(classNameSelection).GetPublicMethods().ToList();

var functionNameSelection = spectreHelper.Prompt.FunctionName(functions);
spectreHelper.WriteStyled($"Function: {functionNameSelection}", Color.Red);

var selectedFunction = functions.GetByName(functionNameSelection);
var parameters = selectedFunction.GetParameters();

// TODO allow for complextype as json input/ additional prompts for inner parameters
//spectreHelper.Table.DisplayParametersTable(parameters);

var parameterValues = spectreHelper.PromptForParameters(parameters);

var result = await selectedFunction.RunMethodAsync(parameterValues);

spectreHelper.DisplayObject(result);

// TODO: Test IRenderable.Tree
// TODO: https://spectreconsole.net/prompts/text

// TODO: implement prompts for method params

Console.ReadLine();
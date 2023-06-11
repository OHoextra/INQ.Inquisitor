using System.Reflection;
using System.Text.Json;
using INQ.Inquisitor.App.Converters.JsonConverters;
using INQ.Inquisitor.Console.Spectre.Helpers.Components;
using Newtonsoft.Json;
using Spectre.Console;

namespace INQ.Inquisitor.Console.Spectre.Helpers;

public class SpectreHelper
{
    private readonly Color _backgroundColor;
    private readonly Color _foregroundColor;

    public SpectreHelper(Color? backgroundColor = null, Color? foregroundColor = null)
    {
        _backgroundColor = backgroundColor ?? Color.Black;
        _foregroundColor = foregroundColor ?? Color.Green;

        Prompt = new SelectionPromptHelper(_backgroundColor, _foregroundColor);
        Table = new TableHelper(_backgroundColor, _foregroundColor);
    }

    public Dictionary<string, object> PromptForParameters(IEnumerable<ParameterInfo> parameters)
    {
        var parameterValues = new Dictionary<string, object>();
        foreach (var parameter in parameters)
        {
            var prompt = new TextPrompt<string>($"{parameter.Name} (Type: {parameter.ParameterType.Name}) =");
            var parameterValue = AnsiConsole.Prompt(prompt);
            var convertedValue = Convert.ChangeType(parameterValue, parameter.ParameterType);
            parameterValues.Add(parameter.Name ?? "Unnamed-parameter", convertedValue);
        }

        return parameterValues;
    }

    public void WriteStyled(string text, Color? foregroundColor = null, Color? backgroundColor = null, Decoration? decoration = null)
    {
        foregroundColor ??= _foregroundColor;
        backgroundColor ??= _backgroundColor;

        var style = new Style(foregroundColor, backgroundColor, decoration);

        var markup = new Markup(text + Environment.NewLine, style);
        AnsiConsole.Write(markup);

        //AnsiConsole.MarkupLine(text, style);
    }

    public void DisplayObject(object? obj)
    {

        var settings = new JsonSerializerSettings
        {
            Converters = { new NoEnumerableEncapsulationConverter() }
        };

        string jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented, settings);

        var objLines = jsonString.Split(Environment.NewLine);
        foreach (var line in objLines)
        {
            AnsiConsole.WriteLine(line);
        }
        
    }

    public SelectionPromptHelper Prompt { get; }

    public TableHelper Table { get; }
}


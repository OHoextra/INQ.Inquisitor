using Spectre.Console;

namespace INQ.Inquisitor.Console.Spectre.Helpers.Components;

public class SelectionPromptHelper
{
    private readonly Color _foregroundColor;
    private readonly Color _backgroundColor;

    private readonly Style _highlightStyle;
    private readonly Style _disabledStyle;

    public SelectionPromptHelper(Color? backgroundColor = null, Color? foregroundColor = null, Style? baseStyle = null, Style? highlightStyle = null)
    {
        _backgroundColor = backgroundColor ?? Color.Black;
        _foregroundColor = foregroundColor ?? Color.Green;
        //_backgroundColorMarkup = _backgroundColor.ToMarkup();
        //_foregroundColorMarkup = _foregroundColor.ToMarkup();

        _disabledStyle = baseStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor);
        _highlightStyle = highlightStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor, decoration: Decoration.Underline);
    }

    public TType Prompt<TType>(string title, IEnumerable<TType> choices)
        where TType : notnull
    {
        //AnsiConsole.Clear();

        var prompt = new SelectionPrompt<TType>()
            .Title(title)
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more choices)[/]")
            .AddChoices(choices)
            .HighlightStyle(_highlightStyle);

        prompt.DisabledStyle = _disabledStyle;
   
        var result =  AnsiConsole.Prompt(prompt);
        //AnsiConsole.Write(Environment.NewLine);

        return result;
    }

    public string PromptClassName(IEnumerable<Type> types)
    {
        var classNames = types.Select(type => type.Name);
        return Prompt("What class would you like to use?", classNames);
    }

    public string PromptFunctionName(IEnumerable<string> methodNames)
    {
        return Prompt("What function would you like to use?", methodNames);
    }
}


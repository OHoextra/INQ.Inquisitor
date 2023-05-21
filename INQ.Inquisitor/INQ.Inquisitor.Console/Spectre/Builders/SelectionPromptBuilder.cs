using Spectre.Console;

namespace INQ.Inquisitor.Console.Spectre.Builders;

public class SelectionPromptBuilder
{
    private readonly Color _foregroundColor;
    private readonly Color _backgroundColor;

    private readonly Style _highlightStyle;
    private readonly Style _disabledStyle;

    public SelectionPromptBuilder(Color? backgroundColor = null, Color? foregroundColor = null, Style ? baseStyle = null, Style? highlightStyle = null)
    {
        _backgroundColor = backgroundColor ?? Color.Black;
        _foregroundColor = foregroundColor ?? Color.Green;
        //_backgroundColorMarkup = _backgroundColor.ToMarkup();
        //_foregroundColorMarkup = _foregroundColor.ToMarkup();

        _disabledStyle = baseStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor);
        _highlightStyle = highlightStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor, decoration: Decoration.Underline);
    }

    public SelectionPrompt<TType> Build<TType>(string title, IEnumerable<TType> choices)
        where TType : notnull
    {
        var prompt = new SelectionPrompt<TType>()
            .Title(title)
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more choices)[/]")
            .AddChoices(choices)
            .HighlightStyle(_highlightStyle);

        prompt.DisabledStyle = _disabledStyle;

        return prompt;
    }
}


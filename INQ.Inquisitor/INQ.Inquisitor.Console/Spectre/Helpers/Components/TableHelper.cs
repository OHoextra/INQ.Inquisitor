using System.ComponentModel;
using System.Reflection;
using INQ.Inquisitor.App.Exceptions;
using INQ.Inquisitor.App.Extensions;
using INQ.Inquisitor.App.Helper;
using Spectre.Console;
using Color = Spectre.Console.Color;

namespace INQ.Inquisitor.Console.Spectre.Helpers.Components;

public class TableHelper
{
    private readonly Color _foregroundColor;
    private readonly Color _backgroundColor;
    //private readonly string _foregroundColorMarkup;
    //private readonly string _backgroundColorMarkup;
    private readonly Style _borderStyle;
    private readonly Style _baseStyle;
    private readonly Style _headerStyle;
    private readonly Style _titleStyle;

    public TableHelper(Color? backgroundColor = null, Color? foregroundColor = null, Color? borderColor = null, Style? borderStyle = null, Style? baseStyle = null, Style? headerStyle = null, Style? titleStyle = null)
    {
        _backgroundColor = backgroundColor ?? Color.Black;
        _foregroundColor = foregroundColor ?? Color.Green;
        //_backgroundColorMarkup = _backgroundColor.ToMarkup();
        //_foregroundColorMarkup = _foregroundColor.ToMarkup();

        _borderStyle = borderStyle ?? borderColor ?? _foregroundColor;
        _baseStyle = baseStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor);
        _headerStyle = headerStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor, decoration: Decoration.Italic);
        _titleStyle = titleStyle ?? new Style(foreground: _foregroundColor, background: _backgroundColor, decoration: Decoration.SlowBlink);
    }

    public void DisplayParametersTable(IEnumerable<ParameterInfo> parameters)
    {
        var table = new Table()
            .Title("Parameters", style: _titleStyle)
            .AddColumn(new TableColumn(new Markup("Name", _headerStyle)))
            .AddColumn(new TableColumn(new Markup("Type", _headerStyle)));

        table.Border = TableBorder.Horizontal;
        table.BorderStyle = _borderStyle;

        foreach (var parameter in parameters)
        {

            table.AddRow(
                new Markup(parameter.Name ?? "Unnamed-Parameter", _baseStyle),
                new Markup(parameter.ParameterType.Name, _baseStyle));

        }

        AnsiConsole.Write(table);
    }

    public void DisplayClassFunctionsTable(IEnumerable<Type> types)
    {
        if (types == default)
            throw new ArgumentDefaultException(nameof(types));

        var typesList = types.ToList();
        if (!typesList.Any())
            throw new ArgumentEmptyException(nameof(types));

        var table = new Table()
            .Title("Functions", style: _titleStyle)
            .AddColumn(new TableColumn(new Markup("Assembly", _headerStyle)))
            .AddColumn(new TableColumn(new Markup("Namespace", _headerStyle)))
            .AddColumn(new TableColumn(new Markup("Class", _headerStyle)))
            .AddColumn(new TableColumn(new Markup("Function", _headerStyle)));

        table.Border = TableBorder.Horizontal;
        table.BorderStyle = _borderStyle;

        foreach (var type in typesList)
        {
            var typeMethods = type.GetPublicMethods();
            foreach (var typeMethod in typeMethods)
            {
                table.AddRow(
                    new Markup(type.Assembly.GetName().Name ?? "EMPTY", _baseStyle),
                    new Markup(type.Namespace ?? "EMPTY", _baseStyle),
                    new Markup(type.Name, _baseStyle),
                    new Markup(typeMethod.Name, _baseStyle));
            }
        }

        AnsiConsole.Write(table);
    }

}


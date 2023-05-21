using INQ.Inquisitor.Console.Spectre.Builders;
using Spectre.Console;

namespace INQ.Inquisitor.Console.Spectre;

public class SpectreHelper
{
    private readonly Color _backgroundColor;
    private readonly Color _foregroundColor;

    public SpectreHelper(Color? backgroundColor = null, Color? foregroundColor = null)
    {
        _backgroundColor = backgroundColor ?? Color.Black;
        _foregroundColor = foregroundColor ?? Color.Green;

        SelectionPrompt = new SelectionPromptBuilder(_backgroundColor, _foregroundColor);
        Table = new TableBuilder(_backgroundColor, _foregroundColor);
    }

    public SelectionPromptBuilder SelectionPrompt { get; }

    public TableBuilder Table { get; }
}


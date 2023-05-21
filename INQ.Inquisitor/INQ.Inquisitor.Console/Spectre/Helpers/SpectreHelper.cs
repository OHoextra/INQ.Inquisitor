using INQ.Inquisitor.Console.Spectre.Helpers.Components;
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

        SelectionPrompt = new SelectionPromptHelper(_backgroundColor, _foregroundColor);
        Table = new TableHelper(_backgroundColor, _foregroundColor);
    }

    public SelectionPromptHelper SelectionPrompt { get; }

    public TableHelper Table { get; }
}


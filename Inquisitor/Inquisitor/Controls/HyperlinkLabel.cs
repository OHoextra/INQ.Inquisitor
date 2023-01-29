namespace Inquisitor.Controls;

public class HyperlinkLabel : Label
{
    public static readonly BindableProperty UrlProperty =
        BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkLabel), null);

    public string Url
    {
        get => (string)GetValue(UrlProperty);
        set => SetValue(UrlProperty, value);
    }

    public HyperlinkLabel() { }

    public HyperlinkLabel(string text = "", string url = "")
    {
        if (!string.IsNullOrWhiteSpace(text))
            Text = text;

        if (!string.IsNullOrWhiteSpace(url))
            Url = url;

        TextDecorations = TextDecorations.Underline;
        TextColor = Colors.White;
        GestureRecognizers.Add(new TapGestureRecognizer
        {
            // Launcher.OpenAsync is provided by Essentials.
            Command = new Command(async () => await Launcher.OpenAsync(Url))
        });
    }
}


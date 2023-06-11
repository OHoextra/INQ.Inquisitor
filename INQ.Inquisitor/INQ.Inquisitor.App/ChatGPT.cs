using ChatGPT.Net;

namespace INQ.Inquisitor.App;

public static class ChatGPT
{
    public static async Task<string?> Exchange(string prompt)
    {
        var apiKey = "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";
        var bot = new ChatGpt($"{apiKey}");

        return await bot.Ask(prompt);
    }
}


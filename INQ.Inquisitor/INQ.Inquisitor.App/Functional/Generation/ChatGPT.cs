using ChatGPT.Net;

namespace INQ.Inquisitor.App.Functional.Generation;

public static class ChatGPT
{
    public static async Task<string?> Ask(string prompt)
    {
        const string apiKey = "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";
        var bot = new ChatGpt($"{apiKey}");

        return await bot.Ask(prompt);
    }
}
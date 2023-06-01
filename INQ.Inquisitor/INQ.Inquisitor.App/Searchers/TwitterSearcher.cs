using System.Security.Cryptography;
using System.Text;
using RestSharp;

namespace INQ.Inquisitor.App.Searchers;

public static class TwitterSearcher
{
    private static readonly string ClientId = "cjNCc2l5ejB3ODdFbktnUFc4Yy06MTpjaQ";
    private static readonly string ClientSecret = "AZUeV3YhimFnmW6w3r03qZCvBNrUVlZLqNK4Ds3VU1fCoi8pY-";

    private static readonly string BearerToken = "AAAAAAAAAAAAAAAAAAAAAI35nQEAAAAA1B3UJIta7IsZthZoz8bDgLa0cyU%3DOaZVavj3bVmQ6nUIdYfAD2dg9hdA70j7elSIM6ki7shUeQCMmW";

    private static readonly string ConsumerKey = "CaBCOgCoPq0tnhp2eValQJI5i";
    private static readonly string ConsumerSecret = "PAp79eTKVj3Gaqmkti4tAK8ug2Avi0xAWVqY3cvxmqTBFCaoO2";
    private static readonly string AccessToken = "1239697746938023936-88p5RbarRKPC3KFcrzTWDu1EHK2lJh";
    private static readonly string AccessTokenSecret = "m7OSlnbUfuarW02TqbC3wPbKv4EAXZuAPLK8fwf8M30ai";

    public static async Task<string> SearchUser(string query)
    {
        // Twitter API endpoint
        string endpoint = $"https://api.twitter.com/2/users/by/username/{query}";

        var client = new RestClient(endpoint);
        var request = new RestRequest();
        request.AddHeader("Authorization", $"Bearer {BearerToken}");
        request.AddUrlSegment("username", query);
        var response = client.Execute(request);

        if (response.IsSuccessful)
        {
            return response.Content ?? string.Empty;
        }

        return response.ErrorMessage ?? string.Empty;
    }
    private static string GenerateOAuthHeader(string url, Dictionary<string, string> parameters, string consumerKey, string consumerSecret, string accessToken, string accessTokenSecret)
    {
        // Generate the timestamp and nonce
        var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        var nonce = Guid.NewGuid().ToString("N");

        // Add the required OAuth parameters
        var oauthParams = new Dictionary<string, string>
        {
            { "oauth_consumer_key", consumerKey },
            { "oauth_signature_method", "HMAC-SHA1" },
            { "oauth_timestamp", timestamp },
            { "oauth_nonce", nonce },
            { "oauth_version", "1.0" },
            { "oauth_token", accessToken }
        };

        // Combine all parameters
        var allParams = new Dictionary<string, string>(parameters);
        foreach (var oauthParam in oauthParams)
        {
            allParams.Add(oauthParam.Key, oauthParam.Value);
        }

        // Sort the parameters alphabetically
        var sortedParams = allParams.OrderBy(p => p.Key)
                                    .ThenBy(p => p.Value)
                                    .ToDictionary(p => p.Key, p => p.Value);

        // Build the base string
        var baseString = new StringBuilder();
        baseString.Append("GET&");
        baseString.Append(Uri.EscapeDataString(url));
        baseString.Append("&");
        baseString.Append(Uri.EscapeDataString(string.Join("&", sortedParams.Select(p => $"{p.Key}={p.Value}"))));

        // Generate the signing key
        var signingKey = $"{Uri.EscapeDataString(consumerSecret)}&{Uri.EscapeDataString(accessTokenSecret)}";

        // Calculate the signature
        using var hmac = new HMACSHA1(Encoding.ASCII.GetBytes(signingKey));
        var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.ASCII.GetBytes(baseString.ToString())));

        // Add the signature to the OAuth parameters
        oauthParams.Add("oauth_signature", signature);

        // Generate the OAuth header string
        var oauthHeader = new StringBuilder();
        oauthHeader.Append("OAuth ");
        oauthHeader.Append(string.Join(", ", oauthParams.Select(p => $"{Uri.EscapeDataString(p.Key)}=\"{Uri.EscapeDataString(p.Value)}\"")));

        return oauthHeader.ToString();
    }
}

    /* TODO: this api requries elevated priviliges, use api v2 instead
    public static async Task<List<User>> SearchUser(string searchQuery)
    {
        var auth = new SingleUserAuthorizer
        {
            CredentialStore = new SingleUserInMemoryCredentialStore
            {
                ConsumerKey = "gtZUt5jh1quKqXgAvqDyroQQO",
                ConsumerSecret = "VwordVjlJqwZZNtDKWMYIOf5l5lFjvw2UmD6k1Tp4OAgnYJKY8",
                AccessToken = "1239697746938023936-R7sw1hN7aMqC1A4w8TNZpdlDJDHOsm",
                AccessTokenSecret = "ipALheAr2gNfM4C0dUHpBfIrqylRp7CAbg70kipol5CBc"
            }
        };

        var twitterContext = new TwitterContext(auth);

        var users = await (from user in twitterContext.User
                where user.Type == UserType.Search &&
                      user.Query == searchQuery &&
                      user.Count == 10
                select user)
            .ToListAsync();

        return users;
    } */



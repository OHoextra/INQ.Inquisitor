using System.Security.Cryptography;
using System.Text;

namespace INQ.Inquisitor.App;

public class OAuthHttpClient : HttpClient
{
    public OAuthHttpClient(string endpoint, string consumerKey, string consumerSecret, string accessToken, string accessTokenSecret)
    {
        var oauthHeader =
            GenerateOAuthHeader(endpoint, consumerKey, consumerSecret, accessToken, accessTokenSecret);
        DefaultRequestHeaders.Add("Authorization", oauthHeader);
    }

    private string GenerateOAuthHeader(string url, string consumerKey, string consumerSecret, string accessToken,
        string accessTokenSecret)
    {
        var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        var nonce = Guid.NewGuid().ToString("N");

        var oauthParams = new SortedDictionary<string, string>
        {
            { "oauth_consumer_key", consumerKey },
            { "oauth_signature_method", "HMAC-SHA1" },
            { "oauth_timestamp", timestamp },
            { "oauth_nonce", nonce },
            { "oauth_version", "1.0" },
            { "oauth_token", accessToken }
        };

        var baseString = new StringBuilder();
        baseString.Append("GET&");
        baseString.Append(Uri.EscapeDataString(url));
        baseString.Append("&");
        baseString.Append(Uri.EscapeDataString(string.Join("&", oauthParams.Select(kvp => $"{kvp.Key}={kvp.Value}"))));
        
        var signingKey = $"{Uri.EscapeDataString(consumerSecret)}&{Uri.EscapeDataString(accessTokenSecret)}";
        using var hmac1 = new HMACSHA1(Encoding.ASCII.GetBytes(signingKey));
        var signature = Convert.ToBase64String(hmac1.ComputeHash(Encoding.ASCII.GetBytes(baseString.ToString())));
        oauthParams.Add("oauth_signature", signature);
        var oauthHeader = new StringBuilder();

        oauthHeader.Append("OAuth ");
        oauthHeader.Append(string.Join(", ",
            oauthParams.Select(kvp => $"{kvp.Key}=\"{Uri.EscapeDataString(kvp.Value)}\"")));

        return oauthHeader.ToString();
    }
}

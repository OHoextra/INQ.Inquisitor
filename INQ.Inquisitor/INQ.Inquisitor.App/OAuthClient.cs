namespace INQ.Inquisitor.App;

public class OAuthClient : HttpClient
{
    public OAuthClient(string endpoint, string consumerKey, string consumerSecret, string accessToken,
        string accessTokenSecret)
    {
        var oauthHeader =
            GenerateOAuthHeader(endpoint, consumerKey, consumerSecret, accessToken, accessTokenSecret);
        DefaultRequestHeaders.Add("Authorization", oauthHeader);
    }

    private string GenerateOAuthHeader(string url, string consumerKey, string consumerSecret, string accessToken,
        string accessTokenSecret)
    {
        // Generate the timestamp and nonce
        var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        var nonce = Guid.NewGuid().ToString("N");

        // Add the required OAuth parameters
        var oauthParams = new SortedDictionary<string, string>
        {
            { "oauth_consumer_key", consumerKey },
            { "oauth_signature_method", "HMAC-SHA1" },
            { "oauth_timestamp", timestamp },
            { "oauth_nonce", nonce },
            { "oauth_version", "1.0" },
            { "oauth_token", accessToken }
        };

        // Build the base string
        var baseString = new System.Text.StringBuilder();
        baseString.Append("GET&");
        baseString.Append(Uri.EscapeDataString(url));
        baseString.Append("&");
        baseString.Append(
            Uri.EscapeDataString(string.Join("&", oauthParams.Select(kvp => $"{kvp.Key}={kvp.Value}"))));

        // Generate the signing key
        var signingKey = $"{Uri.EscapeDataString(consumerSecret)}&{Uri.EscapeDataString(accessTokenSecret)}";

        // Calculate the signature
        using var hmacsha1 =
            new System.Security.Cryptography.HMACSHA1(System.Text.Encoding.ASCII.GetBytes(signingKey));
        var signature =
            Convert.ToBase64String(
                hmacsha1.ComputeHash(System.Text.Encoding.ASCII.GetBytes(baseString.ToString())));

        // Add the signature to the OAuth parameters
        oauthParams.Add("oauth_signature", signature);

        // Generate the OAuth header string
        var oauthHeader = new System.Text.StringBuilder();
        oauthHeader.Append("OAuth ");
        oauthHeader.Append(string.Join(", ",
            oauthParams.Select(kvp => $"{kvp.Key}=\"{Uri.EscapeDataString(kvp.Value)}\"")));

        return oauthHeader.ToString();
    }
}

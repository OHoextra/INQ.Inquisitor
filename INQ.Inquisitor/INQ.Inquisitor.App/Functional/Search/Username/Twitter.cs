using RestSharp;

namespace INQ.Inquisitor.App.Functional.Search.Username;

public static class Twitter
{
    private static readonly string ClientId = "cjNCc2l5ejB3ODdFbktnUFc4Yy06MTpjaQ";
    private static readonly string ClientSecret = "AZUeV3YhimFnmW6w3r03qZCvBNrUVlZLqNK4Ds3VU1fCoi8pY-";

    private static readonly string BearerToken =
        "AAAAAAAAAAAAAAAAAAAAAI35nQEAAAAA1B3UJIta7IsZthZoz8bDgLa0cyU%3DOaZVavj3bVmQ6nUIdYfAD2dg9hdA70j7elSIM6ki7shUeQCMmW";

    private static readonly string ConsumerKey = "CaBCOgCoPq0tnhp2eValQJI5i";
    private static readonly string ConsumerSecret = "PAp79eTKVj3Gaqmkti4tAK8ug2Avi0xAWVqY3cvxmqTBFCaoO2";
    private static readonly string AccessToken = "1239697746938023936-88p5RbarRKPC3KFcrzTWDu1EHK2lJh";
    private static readonly string AccessTokenSecret = "m7OSlnbUfuarW02TqbC3wPbKv4EAXZuAPLK8fwf8M30ai";

    public static async Task<string> Search_User(string query)
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
}


/* TODO: this api requries elevated priviliges, use api v2 instead
public static async Task<List<User>> Search_User(string searchQuery)
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
            where user.Type == UserType.Search_PhoneNumber &&
                  user.Query == searchQuery &&
                  user.Count == 10
            select user)
        .ToListAsync();

    return users;
} */



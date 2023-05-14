using Tweetinvi;
using Newtonsoft.Json;
using Tweetinvi.Models;

namespace INQ.Inquisitor.App;

public static class TwitterSearcher
{
    private static readonly string ClientId = "cjNCc2l5ejB3ODdFbktnUFc4Yy06MTpjaQ";
    private static readonly string ClientSecret = "AZUeV3YhimFnmW6w3r03qZCvBNrUVlZLqNK4Ds3VU1fCoi8pY-";

    private static readonly string BearerToken = "AAAAAAAAAAAAAAAAAAAAAI35nQEAAAAA1B3UJIta7IsZthZoz8bDgLa0cyU%3DOaZVavj3bVmQ6nUIdYfAD2dg9hdA70j7elSIM6ki7shUeQCMmW";
   
    private static readonly string ConsumerKey = "CaBCOgCoPq0tnhp2eValQJI5i";
    private static readonly string ConsumerSecret = "PAp79eTKVj3Gaqmkti4tAK8ug2Avi0xAWVqY3cvxmqTBFCaoO2";
    private static readonly string AccessToken = "1239697746938023936-88p5RbarRKPC3KFcrzTWDu1EHK2lJh";
    private static readonly string AccessTokenSecret = "m7OSlnbUfuarW02TqbC3wPbKv4EAXZuAPLK8fwf8M30ai";

    public static async Task<string> SearchUsers(string userName)
    {
        // Replace the following with your Twitter API credentials
        string apiKey = "YOUR_API_KEY";
        string apiSecret = "YOUR_API_SECRET";
        string accessToken = "YOUR_ACCESS_TOKEN";
        string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";


        // Set the user context access token and secret
        string userContextAccessToken = "YOUR_USER_CONTEXT_ACCESS_TOKEN";
        string userContextAccessTokenSecret = "YOUR_USER_CONTEXT_ACCESS_TOKEN_SECRET";

        // Set the user context consumer key and secret
        string userContextConsumerKey = "YOUR_USER_CONTEXT_CONSUMER_KEY";
        string userContextConsumerSecret = "YOUR_USER_CONTEXT_CONSUMER_SECRET";

        // Create the user context credentials
        var userContextCredentials = new TwitterCredentials(
            userContextAccessToken,
            userContextAccessTokenSecret,
            userContextConsumerKey,
            userContextConsumerSecret
        );
        var userContextClient = new TwitterClient(userContextCredentials);
        var bearerToken = await userContextClient.Auth.CreateBearerTokenAsync();
        var appCredentials = new TwitterCredentials(apiKey, apiSecret, accessToken, accessTokenSecret)
        {
            BearerToken = bearerToken
        };

        // Create the main TwitterClient using the AppCredentials
        var appClient = new TwitterClient(appCredentials);
        // Make the API request with the main client
        var user = await appClient.UsersV2.GetUserByNameAsync(userName);

        return JsonConvert.SerializeObject(user, formatting: Formatting.Indented, new JsonSerializerSettings
        {
            MaxDepth = 10,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        });
    }



    /* TODO: this api requries elevated priviliges, use api v2 instead
    public static async Task<List<User>> SearchUsers(string searchQuery)
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
    }


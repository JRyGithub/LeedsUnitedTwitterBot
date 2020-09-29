using RestSharp;
using System;
using System.IO;

namespace LeedsTwitterBot.ApiServices
{
    public class SendTweet
    {
        private string consumerAPIKey = "22UfW93uYAcTg9OKQLgqRlEi8";
        private string consumerAPISecret = "BcO35U70xsQZTsioSkvsxoAB7qiBqPQgwmKdSW3YzTsTqxinTQ";
        private string oAuthAccessToken = "1301394952048451584-SjV1ByxZpbhseiO3uOU9v7Go7rnoOr";
        private string oAuthAccessTokenSecret = "LeiUZApQ1rKehyglHAgO1ciDhZkQUBW5yCYH0JmXPTi2u";
        public bool SimpleTweet(string tweet)
        {
            var twitterOauthToken = oAuthAccessToken;
            var twitterOauthTokenSecret = oAuthAccessTokenSecret;
            var twitterOauthConsumerKey = consumerAPIKey;
            var twitterOauthConsumerSecret = consumerAPISecret;


            var request = new RestRequest($"1.1/statuses/update.json?status={tweet}", Method.POST);

            var client = new RestClient("https://api.twitter.com")
            {
                Authenticator = RestSharp.Authenticators.OAuth1Authenticator.ForProtectedResource(twitterOauthConsumerKey, twitterOauthConsumerSecret, twitterOauthToken, twitterOauthTokenSecret)
            };
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return true;
       
        }
    }
}
using RestSharp;
using System;
using System.IO;

namespace LeedsTwitterBot
{
    public class SendTweet
    {
        private string tweet = "Hello World";
        private string consumerAPIKey = "hpihcVfSGLwviK26oUnuctpWj";
        private string consumerAPISecret = "zmwDeTPnX0Oig7ZtAdy2tgBqP6n819gTO6enuXsFLKBqbHVmmu";
        private string oAuthAccessToken = "1301394952048451584-4mABjO3BD6vSQZHFzIXvAZ9xjKtsqO";
        private string oAuthAccessTokenSecret = "ukuP7vJIlkao0j5LtGtr2oPXFzW06LgA0YEgPARgbI4s3";
        public void SimpleTweet()
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
        }
    }
}
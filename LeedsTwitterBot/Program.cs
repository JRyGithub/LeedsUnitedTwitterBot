using RestSharp;
using System;
using System.IO;

namespace LeedsTwitterBot
{
    class Program
    {
        private string tweet = "Hello World";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            var tweetSuccess = p.SimpleTweet();
            if (tweetSuccess)
            {
                Console.WriteLine("Tweet was succesfull.");
            }
            else
            {
                Console.WriteLine("Tweet was a failure :( ");
            }
        }
        public Boolean SimpleTweet()
        {
            try
            {
                var client = new RestClient("https://api.twitter.com/1.1/statuses/update.json?status=leeds");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "OAuth oauth_consumer_key=\"GdmIYq8KvQhqzN1hpP08Nfm7c\",oauth_token=\"1301394952048451584-VP2esgql7oBHCoLgynUmQabjPQFRhB\",oauth_signature_method=\"HMAC-SHA1\",oauth_timestamp=\"1599267293\",oauth_nonce=\"upT2VQPgagx\",oauth_version=\"1.0\",oauth_signature=\"Hw3XJEFUkE0acsRew66GIk1oO14%3D\"");
                request.AddHeader("Cookie", "personalization_id=\"v1_nEQMGNedf3ikHnydxVwfYQ==\"; guest_id=v1%3A159911545672516549; lang=en");
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                //{"errors":[{"code":32,"message":"Could not authenticate you."}]}

                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}

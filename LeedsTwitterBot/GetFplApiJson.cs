using RestSharp;
using System;
using System.IO;
using Newtonsoft.Json;

namespace LeedsTwitterBot
{
    public class GetFplApiJson
    {
        public void GetFplJson(){
            var client = new RestClient("https://fantasy.premierleague.com/api/bootstrap-static/");

            client.Timeout = -1;

            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);
            
            dynamic jsonResponse = JsonConvert.DeserializeObject<Models.FplApiResponse>(response.Content);
            
            Console.WriteLine(jsonResponse.GetType());
        }
    }
}
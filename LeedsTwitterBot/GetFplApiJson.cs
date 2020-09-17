using RestSharp;
using System;
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

            var json = JsonConvert.SerializeObject(response.Content);

            dynamic jsonResponse = JsonConvert.DeserializeObject<Models.FplApiResponse>(json);
            
            Console.WriteLine(jsonResponse.GetType());
        }
    }
}
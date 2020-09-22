using RestSharp;
using System;
using Newtonsoft.Json;
using LeedsTwitterBot.Models;

namespace LeedsTwitterBot
{
    public class GetFplApiJson
    {
        public async System.Threading.Tasks.Task GetFplJsonAsync(){
            var client = new RestClient("https://fantasy.premierleague.com/api/bootstrap-static/");

            var response = client.Execute<GlobalModel>(new RestRequest());

           // Console.WriteLine(response.Data.TotalPlayers);
            //client.Timeout = -1;

            //var request = new RestRequest(Method.GET);

            //IRestResponse response = client.Execute(request);

            //var json = JsonConvert.SerializeObject(response.Content);

            //dynamic jsonResponse = JsonConvert.DeserializeObject<GlobalModel>(json);

            //Console.WriteLine(jsonResponse.GetType());
        }
    }
}
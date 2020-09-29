using RestSharp;
using System;
using Newtonsoft.Json;
using LeedsTwitterBot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeedsTwitterBot.ApiServices
{
    public class GetFplApiJson
    {
        public GlobalModel GetFplJson()
        {
            var client = new RestClient("https://fantasy.premierleague.com/api/bootstrap-static/");

            var response = client.Execute<GlobalModel>(new RestRequest());

            GlobalModel fplPayload = JsonConvert.DeserializeObject<GlobalModel>(response.Content);

            return fplPayload;
        }
    }
}
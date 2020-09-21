/*using RestSharp;
using System;
using Newtonsoft.Json;
using LeedsTwitterBot.Models;
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

            dynamic jsonResponse = JsonConvert.DeserializeObject<GlobalModel>(json);
            
            //Console.WriteLine(jsonResponse.GetType());
        }
    }
}*/using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using LeedsTwitterBot.Models;
using Newtonsoft.Json;
using System;

namespace LeedsTwitterBot
{
    public class GetFplApiJson
    {
        private readonly HttpClient _client;

        public GetFplApiJson(HttpClient client)
        {
            _client = client;
        }

        public async void GetFplJson()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string url = "https://fantasy.premierleague.com/api/bootstrap-static/";

            var json = await _client.GetStringAsync(url);

            var ting = JsonConvert.DeserializeObject<GlobalModel>(json);

            Console.WriteLine(ting.GetType());
        }
    }
}
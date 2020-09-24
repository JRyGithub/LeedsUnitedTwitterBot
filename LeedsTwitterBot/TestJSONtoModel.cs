using LeedsTwitterBot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LeedsTwitterBot
{
    public  class TestJSONtoModel
    {
        private readonly string CallerFilePathAttribute = @"C:\Users\Gorilla Rig\Desktop\Projects\LeedsUnitedTwitterBot\LeedsTwitterBot\MiniJson.Json";
        public async System.Threading.Tasks.Task TestJsonToModelAsync()
        {
            Console.WriteLine("1");
            using (StreamReader r = new StreamReader(CallerFilePathAttribute))
            {
                string json = r.ReadToEnd();

                var items = JsonConvert.DeserializeObject<GlobalModel>(json);
                Teams leeds = null;
                   
                foreach(var team in items.Teams)
                {
                    if(team.Name == "Leeds")
                    {
                        leeds = team;
                        break;
                    }                   
                }
                List<Player> leedsPlayers = new List<Player>();

                foreach(var player in items.Players)
                {
                    if (player.TeamCode == 2)
                    {
                        leedsPlayers.Add(player);
                    }
                }
                Console.WriteLine("Leeds Players:");
                foreach (var player in leedsPlayers)
                {
                    Console.WriteLine(player.FirstName + " "+ player.SecondName);
                }
            }

        }
        public static string GetAllProperties(object obj)
        {
            return string.Join(" ", obj.GetType()
                                        .GetProperties()
                                        .Select(prop => prop.GetValue(obj)));
        }

    }
}

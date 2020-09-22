using LeedsTwitterBot.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LeedsTwitterBot
{
    public  class TestJSONtoModel
    {
        private readonly string CallerFilePathAttribute = @"C:\Users\Gorilla Rig\Desktop\Projects\LeedsUnitedTwitterBot\LeedsTwitterBot\EvenSmallerJson.Json";
        public async System.Threading.Tasks.Task TestJsonToModelAsync()
        {
            Console.WriteLine("1");
            using (StreamReader r = new StreamReader(CallerFilePathAttribute))
            {
                string json = r.ReadToEnd();

                var items = JsonConvert.DeserializeObject<GlobalModel>(json);
                Console.WriteLine("PLAYERS");

                foreach(var player in items.Players)
                {
                    Console.WriteLine("Name: "+ player.FirstName + player.SecondName);
                    Console.WriteLine("Position: " + player.Position);
                }

                Console.WriteLine("GAME SETTINGS");
                Console.WriteLine("LeagueJoinPublicMax " + items.GameSettings.LeagueJoinPublicMax);
                Console.WriteLine("TieBreak " + items.GameSettings.LeagueH2hTiebreakStats[0]);

                Console.WriteLine("STATS");
                foreach (var stat in items.StatsOptions)
                {
                    Console.WriteLine("Name of Stat: " + stat.Name);
                }

            }
        }
        
    }
}

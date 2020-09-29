using LeedsTwitterBot.ApiServices;
using LeedsTwitterBot.Models;
using LeedsTwitterBot.Tweets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeedsTwitterBot
{
    public class StartUp
    {
        public void Run()
        {
            GetFplApiJson getFplApiJson = new GetFplApiJson();
            GlobalModel fplPayload = getFplApiJson.GetFplJson();

            HighestScoringPlayerTweet highestScoringPlayerTweet = new HighestScoringPlayerTweet();
            if (highestScoringPlayerTweet.CreateTweet(fplPayload))
            {
                Console.WriteLine("Tweet has fled the coop.");
            }
        }
    }
}

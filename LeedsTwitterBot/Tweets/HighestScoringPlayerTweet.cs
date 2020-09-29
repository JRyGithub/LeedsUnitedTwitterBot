using LeedsTwitterBot.ApiServices;
using LeedsTwitterBot.Models;
using LeedsTwitterBot.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeedsTwitterBot.Tweets
{
    public class HighestScoringPlayerTweet
    {
        public bool CreateTweet(GlobalModel fplPayload)
        {
            bool successTweet = false;

            GetAllLeedsUnitedPlayers getAllLeedsUnitedPlayers = new GetAllLeedsUnitedPlayers();
            GetsLeedsHighestPointScorer getsLeedsHighestPointScorer = new GetsLeedsHighestPointScorer();
            SendTweet sendTweet = new SendTweet();

            List<Player> leedsPlayers = getAllLeedsUnitedPlayers.GetPlayers(fplPayload);

            List<Player> leedsHighestScorers = getsLeedsHighestPointScorer.HighestScorer(leedsPlayers);

            foreach(var player in leedsHighestScorers)
            {
                Console.WriteLine($"The Highest scoring player for Leeds United this week was {player.FirstName} {player.SecondName}.");
                string tweet = $"The Highest scoring player for Leeds United this week was {player.FirstName} {player.SecondName}. They scored {player.EventPoints}. Giving them a total points score of {player.TotalPoints} with {player.GoalsScored} goals scored and {player.Assists} assists.";

                successTweet = sendTweet.SimpleTweet(tweet);
            }
            return successTweet;
        }
    }
}

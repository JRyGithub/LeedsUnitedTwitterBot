using LeedsTwitterBot.Models;
using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeedsTwitterBot.Services
{
    public class GetsLeedsHighestPointScorer
    {
        public List<Player> HighestScorer(List<Player> leedsPlayers)
        {
            IEnumerable<Player> highestScorer = leedsPlayers.MaxBy(x => x.EventPoints);

            return highestScorer.ToList();
        }
    }
}

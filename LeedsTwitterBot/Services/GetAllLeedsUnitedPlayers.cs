using LeedsTwitterBot.Models;
using System.Collections.Generic;

namespace LeedsTwitterBot.Services
{
    public class GetAllLeedsUnitedPlayers
    {
        private readonly int leedsTeamCode = 2;
        public List<Player> GetPlayers(GlobalModel fplPayload)
        {
            List<Player> leedsPlayers = new List<Player>();

            foreach (var player in fplPayload.Players)
            {
                if (player.TeamCode == leedsTeamCode)
                {
                    leedsPlayers.Add(player);
                }
            }

            return leedsPlayers;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeedsTwitterBot.Models
{
    public class GlobalModel
    {
        [JsonProperty("teams")]
        public ICollection<Teams> Teams { get; set; }

        [JsonProperty("elements")]
        public ICollection<Player> Players { get; set; }

        [JsonProperty("events")]
        public ICollection<Event> Events { get; set; }

        [JsonProperty("element_types")]
        public ICollection<PlayerType> PlayerTypes { get; set; }

        [JsonProperty("game_settings")]
        public GameSettings GameSettings { get; set; }

        [JsonProperty("phases")]
        public ICollection<Phase> Phases { get; set; }

        [JsonProperty("element_stats")]
        public ICollection<ElementStats> StatsOptions { get; set; }

        [JsonProperty("total_players")]
        public long TotalPlayers { get; set; }
    }
}

using Newtonsoft.Json;
using System;

namespace LeedsTwitterBot.Models
{
    public class PlayerType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("plural_name")]
        public string PluralName { get; set; }

        [JsonProperty("plural_name_short")]
        public string PluralNameShort { get; set; }

        [JsonProperty("singular_name")]
        public string SingularName { get; set; }

        [JsonProperty("singular_name_short")]
        public string SingularNameShort { get; set; }

        [JsonProperty("squad_select")]
        public int? SquadSelect { get; set; }

        [JsonProperty("squad_min_play")]
        public int? SquadMinPlay { get; set; }

        [JsonProperty("squad_max_play")]
        public int? SquadMaxPlay { get; set; }

        [JsonProperty("ui_shirt_specific")]
        public bool UiShirtSpecific { get; set; }
       
        [JsonProperty("sub_positions_locked")]
        public int? SubPositionsLocked { get; set; }
        
        [JsonProperty("element_count")]
        public int? ElementCount { get; set; }
    }
}

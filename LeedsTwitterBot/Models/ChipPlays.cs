using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeedsTwitterBot.Models
{
    public class ChipPlays
    {     
            [JsonProperty("chip_name")]
            public string ChipName { get; set; }
            [JsonProperty("num_played")]
            public long? NumPlayed { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeedsTwitterBot.Models
{
    public class TopElementInfo
    {
            [JsonProperty("id")]
            public int? Id { get; set; }
            [JsonProperty("points")]
            public long? Points { get; set; }
    }
}

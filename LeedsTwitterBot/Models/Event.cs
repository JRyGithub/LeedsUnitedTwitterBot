using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LeedsTwitterBot.Models
{
    public class Event
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deadline_time")]
        public string Deadline { get; set; }

        [JsonProperty("average_entry_score")]
        public double AverageScore { get; set; }

        [JsonProperty("finished")]
        public bool IsFinished { get; set; }

        [JsonProperty("data_checked")]
        public bool DateChecked { get; set; }

        [JsonProperty("highest_scoring_entry")]
        public int? HighestScoringEntryId { get; set; }

        [JsonProperty("deadline_time_epoch")]
        public int DeadLineTimeEpoch { get; set; }

        [JsonProperty("deadline_time_game_offset")]
        public int DeadLineTimeGameOffset { get; set; }

        [JsonProperty("highest_score")]
        public int? HighestScore { get; set; }

        [JsonProperty("is_previous")]
        public bool IsPrevious { get; set; }

        [JsonProperty("is_current")]
        public bool IsCurrent { get; set; }

        [JsonProperty("is_next")]
        public bool IsNext { get; set; }

        [JsonProperty("chip_plays")]
        public ICollection<ChipPlays> ChipPlays { get; set; }

        [JsonProperty("most_selected")]
        public int? MostSelected { get; set; }

        [JsonProperty("most_transferred_in")]
        public int? MostTransferredIn { get; set; }

        [JsonProperty("top_element")]
        public int? TopElement { get; set; }

        [JsonProperty("top_element_info")]
        public TopElementInfo TopElementInfo { get; set; }

        [JsonProperty("transfers_made")]
        public int? TransfersMade { get; set; }

        [JsonProperty("most_captained")]
        public int? MostCaptained { get; set; }

        [JsonProperty("most_vice_captained")]
        public int? MostViceCaptained { get; set; }    
    }
}

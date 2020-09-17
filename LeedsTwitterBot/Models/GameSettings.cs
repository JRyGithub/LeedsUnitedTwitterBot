using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeedsTwitterBot.Models
{
    public class GameSettings
    {
        [JsonProperty("cup_start_event_id")]
        public long CupStartEventId { get; set; }
          
        [JsonProperty("league_join_private_max")]
        public long LeagueJoinPrivateMax { get; set; }

        [JsonProperty("league_join_public_max")]
        public long LeagueJoinPublicMax { get; set; }

        [JsonProperty("league_max_ko_rounds_private_h2h")]
        public long LeagueMaxKoRoundsPrivateH2h { get; set; }

        [JsonProperty("league_points_h2h_draw")]
        public long LeaguePointsH2hDraw { get; set; }

        [JsonProperty("league_points_h2h_lose")]
        public long LeaguePointsH2hLose { get; set; }

        [JsonProperty("league_points_h2h_win")]
        public long LeaguePointsH2hWin { get; set; }

        [JsonProperty("league_prefix_public")]
        public string LeaguePrefixPublic { get; set; }     
     
        [JsonProperty("squad_squadplay")]
        public long SquadSquadplay { get; set; }

        [JsonProperty("squad_squadsize")]
        public long SquadSquadsize { get; set; }

        [JsonProperty("squad_team_limit")]
        public long SquadTeamLimit { get; set; }

        [JsonProperty("squad_total_spend")]
        public long SquadTotalSpend { get; set; }    
        
        [JsonProperty("sys_vice_captain_enabled")]
        public bool SysViceCaptainEnabled { get; set; }
       
        [JsonProperty("transfers_sell_on_fee")]
        public double TransfersSellOnFee { get; set; }

        [JsonProperty("league_max_size_public_h2h")]
        public long LeagueMaxSizePublicH2h { get; set; }

        [JsonProperty("league_max_size_private_h2h")]
        public long LeagueMaxSizePrivateH2h { get; set; }

        [JsonProperty("league_ko_first_instead_of_random")]
        public long LeagueKoFirstInsteadOfRandom { get; set; }

        [JsonProperty("cup_stop_event_id")]
        public long CupStopEventId { get; set; }
      
        [JsonProperty("cup_qualifying_method")]
        public string CupQualifyingMethod { get; set; }
        
        [JsonProperty("cup_type")]
        public string CupType { get; set; }
        
        [JsonProperty("ui_currency_multiplier")]
        public long UiCurrencyMultiplier { get; set; }

        [JsonProperty("ui_use_special_shirts")]
        public bool UiUseSpecialShirts { get; set; }

        [JsonProperty("ui_special_shirt_exclusions")]
        public Array UiSpecialShirtExclusions { get; set; }
        
        [JsonProperty("stats_form_days")]
        public long StatsFormDays { get; set; }
        
        [JsonProperty("league_h2h_tiebreak_stats")]
        public Array LeagueH2hTiebreakStats { get; set; }
        
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}

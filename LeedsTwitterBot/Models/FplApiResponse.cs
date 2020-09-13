using System;
using System.IO;

namespace LeedsTwitterBot.Models
{
    public class FplApiResponse
    {
        public string events{get;set;}
        public string game_settings{get;set;}
        public string phases{get;set;}
        public string teams{get;set;}
        public string total_players{get;set;}
        public Elements elements{get;set;}
        public string elements_stats{get;set;}
        public string element_types{get;set;}
    }
    public class Elements{
            public string chance_of_playing_next_round {get;set;}
            public string chance_of_playing_this_round {get;set;}
            public string code {get;set;}
            public string cost_change_event {get;set;}
            public string cost_change_event_fall{get;set;}
            public string cost_change_start{get;set;}
            public string cost_change_start_fall{get;set;}
            public string dreamteam_count{get;set;}
            public string element_type {get;set;}
            public string ep_next {get;set;}
            public string ep_this {get;set;}
            public string event_points{get;set;}
            public string first_name {get;set;}
            public string form {get;set;}
            public string id {get;set;}
            public string in_dreamteam {get;set;}
            public string news {get;set;}
            public string news_added {get;set;}
            public string now_cost {get;set;}
            public string photo {get;set;}
            public string points_per_game {get;set;}
            public string second_name {get;set;}
            public string selected_by_percent {get;set;}
            public string special {get;set;}
            public string squad_number {get;set;}
            public string status {get;set;}
            public string team {get;set;}
            public string team_code {get;set;}
            public string total_points {get;set;}
            public string transfers_in{get;set;}
            public string transfers_in_event{get;set;}
            public string transfers_out{get;set;}
            public string transfers_out_event{get;set;}
            public string value_form {get;set;}
            public string value_season {get;set;}
            public string web_name {get;set;}
            public string minutes {get;set;}
            public string goals_scored {get;set;}
            public string assists {get;set;}
            public string clean_sheets {get;set;}
            public string goals_conceded {get;set;}
            public string own_goals{get;set;}
            public string penalties_saved{get;set;}
            public string penalties_missed{get;set;}
            public string yellow_cards {get;set;}
            public string red_cards{get;set;}
            public string saves{get;set;}
            public string bonus {get;set;}
            public string bps {get;set;}
            public string influence {get;set;}
            public string creativity {get;set;}
            public string threat {get;set;}
            public string ict_index {get;set;}
            public string influence_rank {get;set;}
            public string influence_rank_type {get;set;}
            public string creativity_rank {get;set;}
            public string creativity_rank_type {get;set;}
            public string threat_rank {get;set;}
            public string threat_rank_type {get;set;}
            public string ict_index_rank {get;set;}
            public string ict_index_rank_type {get;set;}
            public string corners_and_indirect_freekicks_order {get;set;}
            public string corners_and_indirect_freekicks_text {get;set;}
            public string direct_freekicks_order {get;set;}
            public string direct_freekicks_text {get;set;}
            public string penalties_order {get;set;}
            public string penalties_text {get;set;}
    }
}
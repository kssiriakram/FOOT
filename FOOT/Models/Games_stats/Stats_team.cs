namespace FOOT.Models.Games_stats
{
    public class Stats_team
    {
        public int shots_on_goals { get; set; }
        public int shots_off_goals { get; set; }
        public int total_shots { get; set; }
        public int blocked_shots { get; set; }
        public int insidebox_shots { get; set; }
        public int outsidebox_shots { get; set; }
        public int fouls { get; set; }
        public int corners { get; set; }
        public int offsides   { get; set; }
        public float possession { get; set; }
        public int yellow_cards {get; set; }
        public int red_cards {get; set; }
        public int goal_parades { get; set; }
        public int total_passes { get; set; }
        public int passes_accurate { get; set; }
        public int passes_accuracy  { get; set; }

    }
}

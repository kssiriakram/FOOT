namespace FOOT.Models.Standings
{
    public class Standing
    {
        public int rank { get; set; }
        public int points { get; set; }
        public int goalsDiff { get; set; }
        public string group { get; set; }
        public string form { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public DateTime update { get; set; }
        public Total_standing all { get; set; }
        public Total_standing home { get; set; }
        public Total_standing away { get; set; }

    }
}

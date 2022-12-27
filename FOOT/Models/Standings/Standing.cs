namespace FOOT.Models.Standings
{
    public class Standing
    {
        private int rank { get; set; }
        private int points { get; set; }
        private int goalsDiff { get; set; }
        private string group { get; set; }
        private string form { get; set; }
        private string status { get; set; }
        private string description { get; set; }
        private DateTime update { get; set; }
        private Total_standing all { get; set; }
        private Total_standing home { get; set; }
        private Total_standing away { get; set; }

    }
}

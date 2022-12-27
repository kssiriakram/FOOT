namespace FOOT.Models.Games
{
    public class Score
    {
        private Dictionary<string, string> halftime { get; set; }
        private Dictionary<string, string> fulltime { get; set; }
        private Dictionary<string,string> extratime { get; set; }
        private Dictionary<string,string> penalty { get; set; }
    }
}

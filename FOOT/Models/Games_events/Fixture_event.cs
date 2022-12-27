using FOOT.Models.Games;

namespace FOOT.Models.Games_events
{
    public class Fixture_event
    {
        private Time time {get; set; }
        private Team team {get; set; }
        private Player player {get; set; }
        private Assist assist {get; set; }
        private string type {get; set; }
        private string detail {get; set; }
        private string comments  {get; set; }

    }
}

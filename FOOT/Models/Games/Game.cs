namespace FOOT.Models.Games
{
    public class Game
    {
        public Fixture fixture { get; set; }
        public League league {get; set; }
        public Teams teams {get; set; }
        public Goals goals {get; set; }
        public Score score {get; set; }
    }
}

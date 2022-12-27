namespace FOOT.Models.Games
{
    public class Game
    {
        private Fixture fixture { get; set; }
        private League league {get; set; }
        private Teams teams {get; set; }
        private Goals goals {get; set; }
        private Score score {get; set; }
    }
}

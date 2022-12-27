namespace FOOT.Models.Games
{
    public class Fixture
    {
        private int id { get; set; }
        private string refreee { get; set; }
        private string timezone { get; set; }
        private DateTime date { get; set; }
        private Period period { get; set; }
        private Venue venue  { get; set; }
        private Status status { get; set; }

    }
}

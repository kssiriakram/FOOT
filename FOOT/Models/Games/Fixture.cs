namespace FOOT.Models.Games
{
    public class Fixture
    {
        public int id { get; set; }
        public string refreee { get; set; }
        public string timezone { get; set; }
        public DateTime date { get; set; }
        public Period period { get; set; }
        public Venue venue  { get; set; }
        public Status status { get; set; }

    }
}

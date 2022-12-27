using FOOT.Models.Standings;

namespace FOOT.Models.Games
{
    public class League
    {
        private int id { get; set; }
        private string league_name { get; set; }
        private string region { get; set; }
        private string logo_url {get; set; }
        private string country_flag { get; set; }
        private int season_year { get; set; }
        private string round { get; set; }
        private Dictionary<string,Standing> standings { get; set; }


    }
}

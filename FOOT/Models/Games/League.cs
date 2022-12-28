using FOOT.Models.Standings;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class League
    {
        public int id { get; set; }
        public string league_name { get; set; }
        public string region { get; set; }
        public string logo_url {get; set; }
        public string country_flag { get; set; }
        public int season_year { get; set; }
        public string round { get; set; }
        public Dictionary<string,Standing> standings { get; set; }

        public List<League> GetLeagues()
        {
            List<League> leagues = new List<League>();
            string json = File.ReadAllText("../../../Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                League league = JsonConvert.DeserializeObject<League>(Convert.ToString(result["response"][i]["league"]));
              
                leagues.Add(league);
            }
            return leagues;
        }

        public League GetLeague(JObject result)
        {
            League league = JsonConvert.DeserializeObject<League>(Convert.ToString(result["league"]));
            return league;
        }
    }
}

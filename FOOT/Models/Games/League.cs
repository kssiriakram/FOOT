using FOOT.Models.Standings;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class League
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string league_name { get; set; }
        [JsonProperty("country")]
        public string region { get; set; }
        [JsonProperty("logo")]
        public string logo_url {get; set; }
        [JsonProperty("flag")]
        public string country_flag { get; set; }
        [JsonProperty("season")]
        public string season_year { get; set; }
        [JsonProperty("round")]
        public string round { get; set; }
        [JsonProperty("standings")]
        public List<List<Standing>> standings { get; set; }

        public static List<League> GetLeagues()
        {
            List<League> leagues = new List<League>();
            string json = File.ReadAllText(@"D:\\C# projects\\FOOT\\FOOT\\Repo\\Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                League league = JsonConvert.DeserializeObject<League>(Convert.ToString(result["response"][i]["league"]));
              
                leagues.Add(league);
            }
            return leagues;
        }

        public static League GetLeagueStandings()
        {
         
            string json = File.ReadAllText("../../../Standing.json");
            JObject result = JObject.Parse(json);
            
                League league = JsonConvert.DeserializeObject<League>(Convert.ToString(result["response"][0]["league"]));

            return league;
        }
    }
}

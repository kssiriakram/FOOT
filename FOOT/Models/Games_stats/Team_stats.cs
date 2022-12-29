using FOOT.Models.Games;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games_stats
{
    public class Team_stats
    {
        [JsonProperty("team")]
        public Team team {get; set; }
        [JsonProperty("statistics")]
        public Dictionary<string, string> stats {get; set; }


        // Get  fixture ( passed in parameter in controller ) teams stats 
        // To be seen : working with restApi and how to pass fixture id
        public static List<Team_stats> GetFixture_stats()
        {
            List<Team_stats> Teams_stats = new List<Team_stats>();
            string json = File.ReadAllText("../../../Team_stats.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Team_stats  team_Stats = new Team_stats();
                team_Stats.team = JsonConvert.DeserializeObject<Team>(Convert.ToString(result["response"][i]["team"]));
                for (int j = 0; j < result["response"][i]["statistics"].Count(); j++)
                {
                    Dictionary<string, string> stats = JsonConvert.DeserializeObject<Dictionary<string, string>>(Convert.ToString(result["response"][i]["statistics"][j]));
                    team_Stats.stats = stats;
                }
                Teams_stats.Add(team_Stats);
            }

            return Teams_stats;

        }
    }
}

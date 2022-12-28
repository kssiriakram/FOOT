using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Teams
    {
        [JsonProperty("home")]
        public Team home_team { get; set; }
        [JsonProperty("away")]
        public Team away_team { get; set; }

        public Teams(Team home_team, Team away_team)
        {
            this.home_team = home_team;
            this.away_team = away_team;
        }

        public static List<Teams> GetTeams()
        {
            List<Teams> teams = new List<Teams>();
            string json = File.ReadAllText("../../../Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Team home = JsonConvert.DeserializeObject<Team>(Convert.ToString(result["response"][i]["teams"]["home"]));
                Team away = JsonConvert.DeserializeObject<Team>(Convert.ToString(result["response"][i]["teams"]["away"]));
                teams.Add(new Teams(home,away));
            }
            return teams;
        }

       
    }
}

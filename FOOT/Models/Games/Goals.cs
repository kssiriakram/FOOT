using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Goals
    {
        [JsonProperty("home")]
        public string home_goals { get; set; }
        [JsonProperty("away")]
        public string away_goals { get; set; }


        public static List<Goals> GetGoals()
        {
            List<Goals> goals = new List<Goals>();
            string json = File.ReadAllText("../../../Repo/Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Goals g = JsonConvert.DeserializeObject<Goals>(Convert.ToString(result["response"][i]["goals"]));
                goals.Add(g);
            }
            return goals;
        }

    }
}

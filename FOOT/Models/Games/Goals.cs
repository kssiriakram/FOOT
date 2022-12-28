using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Goals
    {
        public int home_goals { get; set; }
        public int away_goals { get; set; }


        List<Goals> GetGoals()
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

        Goals GetGoal(JObject result)
        {
            return JsonConvert.DeserializeObject<Goals>(Convert.ToString(result["goals"]));
        }
    }
}

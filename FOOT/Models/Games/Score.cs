using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games
{
    public class Score
    {
        public Dictionary<string, string> halftime { get; set; }
        public Dictionary<string, string> fulltime { get; set; }
        public Dictionary<string,string> extratime { get; set; }
        public Dictionary<string,string> penalty { get; set; }

        List<Score> GetScores()
        {
            List<Score> scores = new List<Score>();
            string json = File.ReadAllText("../../../Repo/Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Score s = JsonConvert.DeserializeObject<Score>(Convert.ToString(result["response"][i]["score"]));
                scores.Add(s);
            }
            return scores;
        }

        Score GetScore(JObject result)
        { 
               return  JsonConvert.DeserializeObject<Score>(Convert.ToString(result["score"]));     
        }
    }
}

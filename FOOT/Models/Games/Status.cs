using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Status
    {
        public string status { get; set; }
        public string status_abv { get; set; }
        public int time_elapsed { get; set; }

        public List<Status> GetLeagues()
        {
            List<Status> stauts = new List<Status>();
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

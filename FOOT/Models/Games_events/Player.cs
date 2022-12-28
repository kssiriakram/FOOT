using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games_events
{
    public class Player
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        public string photo_url { get; set; }

        public static List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();
            string json = File.ReadAllText("../../../Events.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Player player = JsonConvert.DeserializeObject<Player>(Convert.ToString(result["response"][i]["player"]));

                players.Add(player);
            }
            return players;
        }
    }
}

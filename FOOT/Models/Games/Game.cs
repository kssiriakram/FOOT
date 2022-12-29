using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games
{
    public class Game
    {
        [JsonProperty("fixture")]
        public Fixture fixture { get; set; }
        [JsonProperty("league")]
        public League league {get; set; }
        [JsonProperty("teams")]
        public Teams teams {get; set; }
        [JsonProperty("goals")]
        public Goals goals {get; set; }
        [JsonProperty("score")]
        public Score score {get; set; }

        public static List<Game> GetGames()
        {
            List<Game> games = new List<Game>();
            string json = File.ReadAllText(@"D:\\C# projects\\FOOT\\FOOT\\Repo\\Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Game game = JsonConvert.DeserializeObject<Game>(Convert.ToString(result["response"][i]));

                games.Add(game);
            }
            return games;
        }
    }
}

using FOOT.Models.Games;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games_events
{
    public class Fixture_event
    {
        [JsonProperty("time")]
        public Time time {get; set; }
        [JsonProperty("team")]
        public Team team {get; set; }
        [JsonProperty("player")]
        public Player player {get; set; }
        [JsonProperty("assist")]
        public Assist assist {get; set; }
        [JsonProperty("type")]
        public string type {get; set; }
        [JsonProperty("detail")]
        public string detail {get; set; }
        [JsonProperty("comments")]
        public string comments  {get; set; }

        public static List<Fixture_event> GetFixture_event()
        {
            List<Fixture_event> fixtures_events = new List<Fixture_event>();
            string json = File.ReadAllText("../../../Events.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Fixture_event fixture_event = JsonConvert.DeserializeObject<Fixture_event>(Convert.ToString(result["response"][i]));

                fixtures_events.Add(fixture_event);
            }
            return fixtures_events;
        }

    }
}

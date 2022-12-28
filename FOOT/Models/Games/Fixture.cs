using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games
{
    public class Fixture
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("referee")]
        public string referee { get; set; }
        [JsonProperty("timezone")]
        public string timezone { get; set; }
        [JsonProperty("date")]
        public DateTime date { get; set; }
        [JsonProperty("periods")]
        public Period period { get; set; }
        [JsonProperty("venue")]
        public Venue venue  { get; set; }
        [JsonProperty("status")]
        public Status status { get; set; }

        public static List<Fixture> GetFixtures()
        {
            List<Fixture> fixtures = new List<Fixture>();
            string json = File.ReadAllText("../../../Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Fixture fixture = JsonConvert.DeserializeObject<Fixture>(Convert.ToString(result["response"][i]["fixture"]));

                fixtures.Add(fixture);
            }
            return fixtures;
        }


    }
}


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games_events
{
    public class Assist
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string player {get; set; }

        public static List<Assist> GetAssits()
        {
            List<Assist> assists = new List<Assist>();
            string json = File.ReadAllText("../../../Events.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Assist assist = JsonConvert.DeserializeObject<Assist>(Convert.ToString(result["response"][i]["assist"]));

                assists.Add(assist);
            }
            return assists;
        }
    }
}

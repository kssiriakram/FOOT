using FOOT.Models.Games;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games_events
{
    public class Time { 
        [JsonProperty("elapsed")]
        public string elapsed {get; set; }
        [JsonProperty("extra")]
        public string extra {get; set; }

        public static List<Time> GetTimes()
        {
            List<Time> times = new List<Time>();
            string json = File.ReadAllText("../../../Events.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Time time = JsonConvert.DeserializeObject<Time>(Convert.ToString(result["response"][i]["time"]));

                times.Add(time);
            }
            return times;
        }
    }


}

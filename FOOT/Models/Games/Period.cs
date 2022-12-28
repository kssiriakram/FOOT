using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games
{
    public class Period
    {
        [JsonProperty("first")]
        public string first { get; set; }
        [JsonProperty("second")]
        public string last { get; set; }

        public static List<Period> GetPeriods()
        {
            List<Period> periods = new List<Period>();
            string json = File.ReadAllText("../../../Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Period period = JsonConvert.DeserializeObject<Period>(Convert.ToString(result["response"][i]["fixture"]["periods"]));

                periods.Add(period);
            }
            return periods;
        }
    }
}

using Newtonsoft.Json;

namespace FOOT.Models.Standings
{
    public class Total_standing
    {
        [JsonProperty("played")]
        public string played { get; set; }
        [JsonProperty("win")]
        public string win { get; set; }
        [JsonProperty("draw")]
        public string draw { get; set; }
        [JsonProperty("lose")]
        public string lose { get; set; }
        [JsonProperty("goals")]
        public Dictionary<string, string> goals { get; set; } 
    }
}

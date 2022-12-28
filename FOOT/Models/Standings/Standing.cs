using FOOT.Models.Games;
using Newtonsoft.Json;

namespace FOOT.Models.Standings
{
    public class Standing
    {
        [JsonProperty("rank")]
        public string rank { get; set; }
        [JsonProperty("team")]
        public Team Team { get; set; }
        [JsonProperty("points")]
        public string points { get; set; }
        [JsonProperty("goalsDiff")]
        public string goalsDiff { get; set; }
        [JsonProperty("group")]
        public string group { get; set; }
        [JsonProperty("form")]
        public string form { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("update")]
        public DateTime update { get; set; }
        [JsonProperty("all")]
        public Total_standing all { get; set; }
        [JsonProperty("home")]
        public Total_standing home { get; set; }
        [JsonProperty("away")]
        public Total_standing away { get; set; }

    }
}

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Team
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("logo")]
        public string url_logo { get; set; }
     
    }

    
}

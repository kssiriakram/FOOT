using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Status
    {
        [JsonProperty("long")]
        public string status { get; set; }
        [JsonProperty("short")]
        public string status_abv { get; set; }
        [JsonProperty("elapsed")]
        public string time_elapsed { get; set; }

        public static List<Status> GetStatus()
        {
            List<Status> status = new List<Status>();
            string json = File.ReadAllText("../../../Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Status statut = JsonConvert.DeserializeObject<Status>(Convert.ToString(result["response"][i]["fixture"]["status"]));

                status.Add(statut);
            }
            return status;
        }

      
    }
}

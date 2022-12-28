using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.Games
{
    public class Venue
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string stadium { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }

        public static List<Venue> GetVenues()
        {
            List<Venue> venues = new List<Venue>();
            string json = File.ReadAllText("../../../Games.json");
            JObject result = JObject.Parse(json);
            for (int i = 0; i < result["response"].Count(); i++)
            {
                Venue venue = JsonConvert.DeserializeObject<Venue>(Convert.ToString(result["response"][i]["fixture"]["venue"]));

                venues.Add(venue);
            }
            return venues;
        }

       
    }
}

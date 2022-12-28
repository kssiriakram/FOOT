using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FOOT.Models.Games
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url_logo { get; set; }
        public DateTime team_stats_update { get; set; }
    }

    
}

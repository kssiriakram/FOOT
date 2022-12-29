using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOOT.Models.News
{
    public class Article
    {
        public string NewsLink { get; set; }
        public string Title { get; set; }   
        public string Image { get; set; }
        public string PublisherLogo { get; set; }
        public string PublisherName { get; set; }
        public string PublisherDate { get; set; }
        public static List<Article> GetArticles()
        {
            List<Article> articles = new List<Article>();
            string json = File.ReadAllText("../../../Repo/Articles.json");
            if (json.Length > 5)
            {
                json = json.Insert(4, "\"data\" : ");
                JObject result = JObject.Parse(json);
                for (int i = 0; i < result["data"].Count(); i++)
                {
                    Article article = JsonConvert.DeserializeObject<Article>(Convert.ToString(result["data"][i]));

                    articles.Add(article);
                }
            }
            return articles;
        }

    }
   
}

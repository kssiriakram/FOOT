using FOOT.Models.Games;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace FOOT.Controllers
{
    public class Matches : Controller
    {
        // GET: Matches
        public ActionResult MatchesForToday()
        {
            List<Game> on_going_games = Game.GetGames()
               .Where(e => e.fixture.status.status_abv != "FT" && e.fixture.status.status_abv != "NS")
               .OrderBy(g => g.league.league_name).ToList();

            List<Game> other_games = Game.GetGames()
                .Where(e => e.fixture.status.status_abv == "FT" || e.fixture.status.status_abv == "NS")
                .OrderBy(g => g.league.league_name).ToList();

            List<League> league_list = League.GetLeagues();

            ViewBag.on_going_games = on_going_games;
            ViewBag.other_games = other_games;
            ViewBag.league_list = league_list;

            return View();
        }

        public ActionResult MatchesForTomorrow()
        {
            List<Game> game = Game.GetGames().OrderBy(g => g.league.league_name).ToList();
            List<League> league_list = League.GetLeagues();

            ViewBag.game = game;
            ViewBag.league_list = league_list;
            return View();
        }

        public ActionResult MatchesForYesterday()
        {
            List<Game> game = Game.GetGames().OrderBy(g => g.league.league_name).ToList();
            List<League> league_list = League.GetLeagues();

            ViewBag.game = game;
            ViewBag.league_list = league_list;
            return View();
        }
        public ActionResult Index()
        {
            List<Game> on_going_games = Game.GetGames()
               .Where(e => e.fixture.status.status_abv != "FT" && e.fixture.status.status_abv != "NS")
               .OrderBy(g => g.league.league_name).ToList();

            List<Game> other_games = Game.GetGames()
                .Where(e => e.fixture.status.status_abv == "FT" || e.fixture.status.status_abv == "NS")
                .OrderBy(g => g.league.league_name).ToList();

            List<League> league_list = League.GetLeagues();

            ViewBag.on_going_games = on_going_games;
            ViewBag.other_games = other_games;
            ViewBag.league_list = league_list;

            return View();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vapor.Models;

namespace Vapor.Controllers
{
    public class GamesController : Controller
    {
        public ActionResult Index()
        {

            var games = GetGames();
            return View(games);

        }

        [Route("Games/Details/{id}")]
        public ActionResult Details(int id)
        {
            var games = GetGames();
            foreach (var game in games)
            {
                if (game.Id == id)
                    return View(game);
            }

            return HttpNotFound();
        }

        private List<Game> GetGames()
        {
            return new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Escape From Tarkov"
                },
                new Game
                {
                    Id = 2,
                    Name = "Eve Online"
                },
                new Game
                {
                    Id = 3,
                    Name = "Dota 2"
                }
            };
        }
    }
}
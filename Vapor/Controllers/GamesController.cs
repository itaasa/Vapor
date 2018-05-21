using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vapor.Models;

namespace Vapor.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {

            var games = _context.Games.ToList();
            return View(games);

        }

        public ActionResult Details(int id)
        {
            var games = _context.Games.Include(c => c.Genre).ToList();
            foreach (var game in games)
            {
                if (game.Id == id)
                    return View(game);
            }

            return HttpNotFound();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vapor.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public GameGenre Genre { get; set; }
    }
}
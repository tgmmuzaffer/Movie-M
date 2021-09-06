using System.Collections.Generic;

namespace Movie_M.Client.Models
{
    public class Imdblist
    {
        public List<Imdb> items { get; set; } = new List<Imdb>();
        public string errorMessage { get; set; }
    }
}

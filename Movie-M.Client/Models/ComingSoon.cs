using System.Collections.Generic;

namespace Movie_M.Client.Models
{
    public class ComingSoon
    {
        public string id { get; set; }
        public string title { get; set; }
        public string fullTitle { get; set; }
        public string year { get; set; }
        public string releaseState { get; set; }
        public string image { get; set; }
        public string runtimeMins { get; set; }
        public string runtimeStr { get; set; }
        public string plot { get; set; }
        public string contentRating { get; set; }
        public string imDbRating { get; set; }
        public string imDbRatingCount { get; set; }
        public string metacriticRating { get; set; }
        public string genres { get; set; }
        public List<GenreList> genreList { get; set; }
        public string directors { get; set; }
        public List<DirectorList> directorList { get; set; }
        public string stars { get; set; }
        public List<StarList> starList { get; set; }
    }
}

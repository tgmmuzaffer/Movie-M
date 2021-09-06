using System.Collections.Generic;

namespace Movie_M.Client.Models
{
    public class SearhMovie
    {
        public List<Search> Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }
}

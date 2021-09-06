using System.Collections.Generic;

namespace Movie_M.Client.Models
{
    public class MostPopularList
    {
        public List<MostPopular> items { get; set; }
        public string errorMessage { get; set; }
    }
}

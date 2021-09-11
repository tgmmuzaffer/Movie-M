using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_M.Client.Areas.Identity.Entity
{
    public class Notation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public string Mail { get; set; }
    }
}

using Movie_M.Client.Areas.Identity.Entity.IEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_M.Client.Areas.Identity.Entity
{
    public class Notation: IMovieEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string MovieId { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public string Mail { get; set; }
    }
}

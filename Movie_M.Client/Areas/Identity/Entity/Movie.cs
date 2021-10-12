using Movie_M.Client.Areas.Identity.Entity.IEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_M.Client.Areas.Identity.Entity
{
    public class Movie: IMovieEntity
    {
        public int Id { get; set; }
        public string MovieId { get; set; }
    }
}

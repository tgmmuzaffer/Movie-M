using Microsoft.EntityFrameworkCore;
using Movie_M.Client.Areas.Identity.Entity;
using Movie_M.Client.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Movie_M.Client.Services
{
    public class MovieNotationService : IMovieNotationService
    {
        private readonly Movie_MClientContext _movie_MClientContext;
        public MovieNotationService(Movie_MClientContext movie_MClientContext)
        {
            _movie_MClientContext = movie_MClientContext;
        }
        public void Add(Notation entity)
        {
            _movie_MClientContext.Notations.Add(entity);
            _movie_MClientContext.SaveChanges();
        }

        public void Delete(Notation entity)
        {
            _movie_MClientContext.Notations.Remove(entity);
            _movie_MClientContext.SaveChanges();
        }

        public Notation Get(string  filter)
        {
          var notifyData= _movie_MClientContext.Notations.Include(a => a.Movies).FirstOrDefault(s=>s.MovieId==filter);
            return notifyData;
        }

        public ICollection<Notation> GetAll(string filter)
        {
            var notifyDatas = _movie_MClientContext.Notations.Include(a => a.Movies).Where(a => a.UserId == filter).ToList();
            return notifyDatas;
        }

        public void Update(Notation entity)
        {
            _movie_MClientContext.Notations.Update(entity);
            _movie_MClientContext.SaveChanges();
        }
    }
}

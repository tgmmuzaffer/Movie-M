using Movie_M.Client.Areas.Identity.Entity.IEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Movie_M.Client.Services
{
   public interface IBaseService<T> where T :class, IMovieEntity, new()
    {
        T Get(string filter);
        ICollection<T> GetAll(string filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

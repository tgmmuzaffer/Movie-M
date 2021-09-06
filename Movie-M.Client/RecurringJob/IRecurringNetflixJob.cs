using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_M.Client.RecurringJob
{
    public interface IRecurringNetflixJob
    {
        void GetMoviePublishInNetflix();
    }
}

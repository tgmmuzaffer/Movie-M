using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Movie_M.Client.RecurringJob
{
    public class RecurringNetflixJob : IRecurringNetflixJob
    {
        //private readonly HttpClient _httpClient;
        //private readonly IMemoryCache _memoryCache;
        //private readonly MemoryCacheEntryOptions _memoryCacheEntryOptions;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public RecurringNetflixJob(IMemoryCache memoryCache, IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    _memoryCache = memoryCache;
        //    _httpClient = new HttpClient();
        //    _memoryCacheEntryOptions = new MemoryCacheEntryOptions
        //    {
        //        AbsoluteExpiration = DateTime.Now.AddDays(30),
        //        Priority = CacheItemPriority.Normal,
        //        Size = 2048
        //    };
        //}
        //public void GetMoviePublishInNetflix()
        //{
        //    var user = _httpContextAccessor.HttpContext?.User;
        //    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
        //    var inMemoryKey = claimsPrincipal.Identity.Name;
        //    var movieidList = _memoryCache.Get(inMemoryKey);
        //    Console.WriteLine("mzffr");
        //}
      

        public void GetMoviePublishInNetflix(HttpContext _context)
        {
            var userName = "";
            if (_context != null)
            {
                if (_context.User != null)
                {
                    var identity = _context.User.Identity;

                    if (identity != null && identity.IsAuthenticated)
                    {
                        userName = identity.Name;
                    }
                }
            }
        }
    }
}

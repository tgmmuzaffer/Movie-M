using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Movie_M.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Movie_M.Client.Areas.Identity.Data;
using Movie_M.Client.RecurringJob;

namespace Movie_M.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _memoryCacheEntryOptions; 
        private readonly UserManager<Movie_MClientUser> _userManager;
        //private readonly RecurringNetflixJob _recurringNetflixJob;
        public HomeController(IMemoryCache memoryCache, UserManager<Movie_MClientUser> userManager/*, RecurringNetflixJob recurringNetflixJob*/)
        {
            //_recurringNetflixJob = recurringNetflixJob;
            _userManager = userManager;
            _memoryCache = memoryCache;
            _httpClient = new HttpClient();
            _memoryCacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddDays(30),
                Priority = CacheItemPriority.Normal,
                Size = 2048
            };

        }
        //[Route("homepage")]
        public async Task<IActionResult> Index()
        {
            var caurasellist = new List<string>();
            var movieList = new List<Movie>();
            var deserialized_res = new Movie();
            this.HttpContext.Request.Cookies.TryGetValue("lastsearched", out string value);
            if (value != null)
            {
                ViewBag.Watchlist = "true";
            }
            string forestgump = "tt0109830";
            string interstellar = "tt0816692";
            string gladyator = "tt0172495";
            string django = "tt1853728";
            string infinitywar = "tt4154756";
            string joker = "tt7286456";
            caurasellist.Add(interstellar);
            caurasellist.Add(forestgump);
            caurasellist.Add(gladyator);
            caurasellist.Add(django);
            caurasellist.Add(infinitywar);
            caurasellist.Add(joker);
            var oursuggested = _memoryCache.Get("oursuggested");
            if (oursuggested == null)
            {
                foreach (var item in caurasellist)
                {
                    var uri = EndPoints.apiEndPoint + "api/getmovie/movieId/" + item;
                    HttpRequestMessage message = new HttpRequestMessage()
                    {
                        Method = System.Net.Http.HttpMethod.Get,
                        RequestUri = new Uri(uri)
                    };
                    using var response = await _httpClient.SendAsync(message);
                    var res = response.EnsureSuccessStatusCode();
                    var reededres = res.Content.ReadAsStringAsync().Result;
                    deserialized_res = JsonConvert.DeserializeObject<Movie>(reededres);
                    movieList.Add(deserialized_res);
                    _memoryCache.Set("oursuggested", movieList, _memoryCacheEntryOptions);
                }
                return View(movieList);

            }
            return View(oursuggested);
        }
    }
}

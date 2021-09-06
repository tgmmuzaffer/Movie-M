using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Movie_M.Client.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movie_M.Client.Controllers
{
    public class HeaderMenuController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _memoryCacheEntryOptions;
        public HeaderMenuController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _httpClient = new HttpClient();
            _memoryCacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddDays(30),
                Priority = CacheItemPriority.Normal,
                Size = 2048
            };
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("imdb-top-250-list")]
        public async Task<IActionResult> GetTop250()
        {
            var top250chche = _memoryCache.Get("top250");
            if (top250chche == null)
            {
                ViewBag.Title = "Imdb Top 250";
                var uri = EndPoints.apiEndPoint + "api/Imdb/top250";
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    Method = System.Net.Http.HttpMethod.Get,
                    RequestUri = new Uri(uri)
                };
                var result = await _httpClient.SendAsync(httpRequestMessage);
                result.EnsureSuccessStatusCode();
                var res = result.Content.ReadAsStringAsync().Result;
                var deserialized_res = JsonConvert.DeserializeObject<Imdblist>(res);
                _memoryCache.Set("top250", deserialized_res, _memoryCacheEntryOptions);
                return View(deserialized_res);
            }
            return View(top250chche);
        }

        [HttpGet("coming-soon")]
        public async Task<IActionResult> ComingSoon()
        {
            ViewBag.Title = "Coming Soon";
            var uri = EndPoints.apiEndPoint + "api/Imdb/comingsoon";
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage
            {
                Method = System.Net.Http.HttpMethod.Get,
                RequestUri = new Uri(uri)

            };
            var result = await _httpClient.SendAsync(httpRequestMessage);
            result.EnsureSuccessStatusCode();
            var res = result.Content.ReadAsStringAsync().Result;
            var deserialized_res = JsonConvert.DeserializeObject<ComingSoonList>(res);
            return View(deserialized_res);
        }


        [HttpGet("most-popular")]
        public async Task<IActionResult> MostPopular()
        {
            ViewBag.Title = "Most Popular";
            var uri = EndPoints.apiEndPoint + "api/Imdb/mostpopullar";
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage
            {
                Method = System.Net.Http.HttpMethod.Get,
                RequestUri = new Uri(uri)

            };
            var result = await _httpClient.SendAsync(httpRequestMessage);
            result.EnsureSuccessStatusCode();
            var res = result.Content.ReadAsStringAsync().Result;
            var deserialized_res = JsonConvert.DeserializeObject<MostPopularList>(res);
            return View(deserialized_res);
        }
    }
}

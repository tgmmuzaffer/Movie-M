using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Movie_M.Client.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movie_M.Client.Controllers
{
    public class SearchMovieController : Controller
    {
        private readonly HttpClient _httpClient;
        public SearchMovieController()
        {
            _httpClient = new HttpClient();
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("search-imdb-id/{i}")]
        public async Task<IActionResult> SearchMovieById(string i)
        {
            var uri = EndPoints.apiEndPoint + "api/getmovie/movieId/" + i;
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = System.Net.Http.HttpMethod.Get,
                RequestUri = new Uri(uri)
            };
            using var response = await _httpClient.SendAsync(message);
            var res = response.EnsureSuccessStatusCode();
            var reededres = res.Content.ReadAsStringAsync().Result;
            var des_res = JsonConvert.DeserializeObject<Movie>(reededres);
            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
            };
            this.HttpContext.Request.Cookies.TryGetValue("lastsearched", out string value);
            string full_list;
            if (value == null)
            {
                full_list = i;
                this.HttpContext.Response.Cookies.Append("lastsearched", full_list, cookieOptions);
            }
            else
            {
                var r = value.Split(",").ToList();
                if (!r.Contains(i))
                {
                    full_list = i + "," + value;
                    this.HttpContext.Response.Cookies.Append("lastsearched", full_list, cookieOptions);
                }
            }
            return View(des_res);
        }
        [Route("searchpage")]
        public IActionResult SearchView()
        {
            return View();
        }
        [HttpPost("searchandresult")]
        public async Task<IActionResult> SearckMovieByName([FromForm] string keyword)
        {
            var uri = EndPoints.apiEndPoint + "api/getmovie/movie/" + keyword;
            HttpRequestMessage message = new HttpRequestMessage ()
            {
                Method = System.Net.Http.HttpMethod.Get,
                RequestUri = new Uri(uri)
            };
            using var response = await _httpClient.SendAsync(message);
            var res = response.EnsureSuccessStatusCode();
            var reededres = res.Content.ReadAsStringAsync().Result;
            var deserialized_res = JsonConvert.DeserializeObject<SearhMovie>(reededres);
            return View(deserialized_res);
        }

    }
}

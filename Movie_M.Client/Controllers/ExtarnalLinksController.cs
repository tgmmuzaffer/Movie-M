using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Movie_M.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movie_M.Client.Controllers
{
    public class ExtarnalLinksController : Controller
    {
        private readonly HttpClient _httpClient;
        public ExtarnalLinksController()
        {
            _httpClient = new HttpClient();
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("extarnal-links/{imdbId}")]
        public async Task<IActionResult>GetExtarnalLinks(string imdbId)
        {
            var uri = EndPoints.apiEndPoint + "api/Imdb/extarnalinks/"+imdbId;
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage
            {
                Method = System.Net.Http.HttpMethod.Get,
                RequestUri = new Uri(uri)

            };
            var result = await _httpClient.SendAsync(httpRequestMessage);
            result.EnsureSuccessStatusCode();
            var res = result.Content.ReadAsStringAsync().Result;
            var deserialized_res = JsonConvert.DeserializeObject<ExtarnaLinks>(res);
            return View(deserialized_res);
        }
    }
}

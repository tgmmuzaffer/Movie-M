using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Movie_M.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Movie_M.Client.ViewComponents
{
    public class LastSearched : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public LastSearched()
        {
            _httpClient = new HttpClient();
        }
        public IViewComponentResult Invoke(string value)
        {
            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
            };
            if (!string.IsNullOrEmpty(value))
            {
                var splitedContent = value.Split(",").ToList();
                if (splitedContent != null)
                {
                    _ = new List<string>();
                    List<string> list;
                    if (splitedContent.Count > 8)
                    {
                        list = splitedContent;
                        var index = list.Count();
                        list.RemoveAt(index-1);
                        var _list = string.Join(",", list);
                        this.HttpContext.Response.Cookies.Append("lastsearched", _list, cookieOptions);
                    }
                    else
                    {
                        list = splitedContent;
                    }
                    var movieList = new List<Movie>();
                    foreach (var item in list)
                    {
                        var uri = EndPoints.apiEndPoint + "api/getmovie/movieId/" + item;
                        HttpRequestMessage message = new HttpRequestMessage()
                        {
                            Method = System.Net.Http.HttpMethod.Get,
                            RequestUri = new Uri(uri)
                        };
                        using var response = _httpClient.SendAsync(message).Result;
                        if (response == null)
                        {
                            return View();
                        }
                        var reededres = response.Content.ReadAsStringAsync().Result;
                        var des_res = JsonConvert.DeserializeObject<Movie>(reededres);
                        movieList.Add(des_res);
                    }
                    return View(movieList);
                }
            }
            return View(null);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Movie_M.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Movie_M.Client.Controllers
{
    public class WatchListController : Controller
    {
        private readonly HttpClient _httpClient;
        public WatchListController()
        {
            _httpClient = new HttpClient();
        }
        [Route("Watch-List")]
        public IActionResult WatchList()
        {
            ViewBag.Title = "Watch List";
            this.HttpContext.Request.Cookies.TryGetValue("addlist", out string value);
            if (!string.IsNullOrEmpty(value))
            {
                var splitedContent = value.Split(",").ToList();
                if (splitedContent != null)
                {
                    _ = new List<string>();
                    List<string> list;
                    if (splitedContent.Count > 9)
                    {
                        list = (List<string>)splitedContent.Take(7);
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
        [HttpPost("addlist")]
        public IActionResult AddList([FromBody] string id)
        {
            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
            };
            this.HttpContext.Request.Cookies.TryGetValue("addlist", out string value);
            string full_list;
            if (value!=null && value.Contains(id))
            {
                return Json(0);
            }
            if (value == null)
            {
                full_list = id;
            }
            else
            {
                full_list = id + "," + value;
            }
            this.HttpContext.Response.Cookies.Append("addlist", full_list, cookieOptions);
            return Json(1);
        }
        [HttpPost("deletefromlist")]
        public IActionResult DeleteFromlist([FromBody] string id)
        {
            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
            };

            this.HttpContext.Request.Cookies.TryGetValue("addlist", out string value);
            if (value == null)
            {
                return Json(0);
            }
            else
            {
                var addlist = value.Split(",").ToList();
                if (addlist.Contains(id))
                {
                    var index = addlist.IndexOf(id);
                    addlist.RemoveAt(index);
                    var newlistjoined = string.Join(",", addlist);
                    this.HttpContext.Response.Cookies.Append("addlist", newlistjoined, cookieOptions);
                    return Json(1);
                }
                else
                {
                    return Json(0);
                }
            }
        }
        [HttpPost("sendNotify")]
        public IActionResult SendNotify([FromBody] string id)
        {
            return Json(0);
        }
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movie_M.Api.Services
{
    public class MainServise
    {
        private readonly HttpClient _client;
        private readonly HttpRequestMessage _requestMessage;
        public MainServise()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("x-rapidapi-key", StaticDetails.x_rapidapi_key);
            _client.DefaultRequestHeaders.Add("x-rapidapi-host", StaticDetails.x_rapidapi_host);
            _requestMessage = new HttpRequestMessage();
        }
        public async Task<string> GetByKeyWord(string keyword, string page="",string year="", string type=""  )
        {
            var uri = StaticDetails.apiEndPoint_Movie + StaticDetails.movie_title_tosearch + keyword;
            string return_type = StaticDetails.return_type_data + "json";
            if (!string.IsNullOrEmpty(page))
            {
                uri = uri + StaticDetails.page + page;
            }
            if (!string.IsNullOrEmpty(year))
            {
                uri = uri + StaticDetails.movie_year_tosearch + year;
            }
            if (!string.IsNullOrEmpty(type))
            {
                uri = uri + StaticDetails.return_type + type;
            }

            _requestMessage.Method = HttpMethod.Get;
            _requestMessage.RequestUri = new Uri(uri + return_type);
            using var response = await _client.SendAsync(_requestMessage);
            response.EnsureSuccessStatusCode();
            var read_response = await response.Content.ReadAsStringAsync();
            return   read_response;
        }

        public async Task<string> GetByID(string i, string type = "", string callback = "", string r = "", string y="", string plot="")
        {
            var uri = StaticDetails.apiEndPoint_Movie + StaticDetails.movie_id_tosearch + i;
            string return_type = StaticDetails.return_type_data + "json";
            if (!string.IsNullOrEmpty(type))
            {
                uri = uri + StaticDetails.return_type + type;
            }
            if (!string.IsNullOrEmpty(callback))
            {
                uri = uri + StaticDetails.callback + callback;
            }
            if (!string.IsNullOrEmpty(r))
            {
                uri = uri + StaticDetails.return_type_data + r;
            }
            if (!string.IsNullOrEmpty(y))
            {
                uri = uri + StaticDetails.movie_year_tosearch + y;
            }
            if (!string.IsNullOrEmpty(plot))
            {
                uri = uri + StaticDetails.plot + plot;
            }
            _requestMessage.Method = HttpMethod.Get;
            _requestMessage.RequestUri = new Uri(uri + return_type);
            using var response = await _client.SendAsync(_requestMessage);
            response.EnsureSuccessStatusCode();
            var read_response = await response.Content.ReadAsStringAsync();
            return read_response;
        }
    }
}

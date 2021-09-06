using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movie_M.Api.Services
{
    public class ImdbService
    {

        private readonly HttpClient _client;
        private readonly HttpRequestMessage _httpRequestMessage;
        public ImdbService()
        {
            _client = new HttpClient();
            _httpRequestMessage = new HttpRequestMessage();
        }

        public async Task<string> GetTop250()
        {
            var uri = StaticDetails.api_top_250_imdb + StaticDetails.api_key_imdb;
            _httpRequestMessage.Method = HttpMethod.Get;
            _httpRequestMessage.RequestUri = new Uri(uri);
            using var response =await _client.SendAsync(_httpRequestMessage);
            response.EnsureSuccessStatusCode();
            var read = await response.Content.ReadAsStringAsync();
            return read;
        }

        public async Task<string> GetMostpopularMovie()
        {
            var uri = StaticDetails.api_mostpopular_imdb + StaticDetails.api_key_imdb;
            _httpRequestMessage.Method = HttpMethod.Get;
            _httpRequestMessage.RequestUri = new Uri(uri);
            using var response = await _client.SendAsync(_httpRequestMessage);
            response.EnsureSuccessStatusCode();
            var read = await response.Content.ReadAsStringAsync();
            return read;
        }
        public async Task<string> GetComingSoonmovie()
        {
            var uri = StaticDetails.api_comingsoon_imdb + StaticDetails.api_key_imdb;
            _httpRequestMessage.Method = HttpMethod.Get;
            _httpRequestMessage.RequestUri = new Uri(uri);
            using var response = await _client.SendAsync(_httpRequestMessage);
            response.EnsureSuccessStatusCode();
            var read = await response.Content.ReadAsStringAsync();
            return read;
        }
        public async Task<string> GetExternalsites(string imdbId)
        {
            var uri = StaticDetails.api_externalLinks_imdb + StaticDetails.api_key_imdb+"/" + imdbId;
            _httpRequestMessage.Method = HttpMethod.Get;
            _httpRequestMessage.RequestUri = new Uri(uri);
            using var response = await _client.SendAsync(_httpRequestMessage);
            response.EnsureSuccessStatusCode();
            var read = await response.Content.ReadAsStringAsync();
            return read;
        }
    }
}

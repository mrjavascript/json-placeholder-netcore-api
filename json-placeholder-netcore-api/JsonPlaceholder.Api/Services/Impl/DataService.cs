using System.Collections.Generic;
using System.Net.Http;
using JsonPlaceholder.Api.Models;
using Newtonsoft.Json;

namespace JsonPlaceholder.Api.Services.Impl
{
    public class DataService : IDataService
    {
        private static readonly HttpClient _httpClient = new();

        public List<Post> GetPosts()
        {
            var response = _httpClient.GetAsync(
                "https://jsonplaceholder.typicode.com/posts").Result;
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<Post>>(content);
        }
    }
}
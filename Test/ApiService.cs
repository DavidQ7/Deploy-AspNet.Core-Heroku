using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Test
{
    public class ApiService
    {
        public HttpClient Client { get; }
        public ApiService(HttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<string> GetFromAPI(string link)
        {
            var response = await Client.GetAsync(link);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

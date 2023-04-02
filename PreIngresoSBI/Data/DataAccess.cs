using PreIngresoSBI.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace PreIngresoSBI.Data
{
    public class DataAccess : IDataAccess
    {
        private List<ServerPost> posts = new();

        public List<ServerPost> Get()
        {
            using (var client = new HttpClient())
            {
                var url = "https://jsonplaceholder.typicode.com/posts";

                var response = client.GetAsync(url).Result;
                var res = response.Content.ReadAsStringAsync().Result;
                posts = JsonSerializer.Deserialize<List<ServerPost>>(res);
            }
            return posts;
        }
    }
}

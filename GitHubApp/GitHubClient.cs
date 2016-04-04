using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GitHubApp
{
    public class GitHubClient
    {
        public virtual async Task<object> GetGitHubRepositories()
        {
            object repositories;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "My App");
                var response = await client.GetAsync("https://api.github.com/repositories");

                var text = await response.Content.ReadAsStringAsync();
                repositories = JsonConvert.DeserializeObject(text);
            }
            return repositories;
        }
    }
}
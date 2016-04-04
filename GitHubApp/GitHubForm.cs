using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GitHubApp
{
    public partial class GitHubForm : Form
    {
        public GitHubForm()
        {
            InitializeComponent();

            repositoriesDataGrid.AutoGenerateColumns = false;
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "My App");
                var response = await client.GetAsync("https://api.github.com/repositories");

                var text = await response.Content.ReadAsStringAsync();
                var repositories = JsonConvert.DeserializeObject(text);

/*
                var repositories = new[]
                {
                    new {name = "repo1", full_name = "masakura/repo1", description = "description repo1"},
                    new {name = "repo2", full_name = "a/longlongreponame", description = "description repo2"},
                    new {name = "repo3", full_name = "masakura/repo3", description = "description repo3"},
                    new {name = "repo4", full_name = "masakura/repo4", description = "long long description..."}
                };
*/

                repositoriesDataGrid.DataSource = repositories;
            }
        }
    }
}
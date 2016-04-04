using System;
using System.Windows.Forms;

namespace GitHubApp
{
    public partial class GitHubForm : Form
    {
        public GitHubForm()
        {
            InitializeComponent();

            repositoriesDataGrid.AutoGenerateColumns = false;
            GitHubClient = new GitHubClient();
        }

        public GitHubClient GitHubClient { get; }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            object repositories;

            repositories = await GitHubClient.GetGitHubRepositories();

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
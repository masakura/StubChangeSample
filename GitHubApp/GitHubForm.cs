using System;
using System.Windows.Forms;

namespace GitHubApp
{
    public partial class GitHubForm : Form
    {
        public GitHubForm()
        {
            GitHubClient = GitHubClient.Current;

            InitializeComponent();

            repositoriesDataGrid.AutoGenerateColumns = false;
        }

        public GitHubClient GitHubClient { get; }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            var repositories = await GitHubClient.GetGitHubRepositories();

            repositoriesDataGrid.DataSource = repositories;
        }
    }
}
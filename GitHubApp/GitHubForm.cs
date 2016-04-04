using System;
using System.Windows.Forms;

namespace GitHubApp
{
    public partial class GitHubForm : Form
    {
        public GitHubForm()
        {
            GitHubClient = new GitHubClient();
            // GitHubClient = new GitHubClientStub();

            InitializeComponent();

            repositoriesDataGrid.AutoGenerateColumns = false;
        }

        public GitHubClient GitHubClient { get; }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            object repositories;

            repositories = await GitHubClient.GetGitHubRepositories();

            repositoriesDataGrid.DataSource = repositories;
        }
    }
}
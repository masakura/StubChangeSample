using System.Windows.Forms;

namespace GitHubApp
{
    public static class Bootstrap
    {
        public static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GitHubForm());
        }
    }
}
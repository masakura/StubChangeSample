using System;

namespace GitHubApp.Stub
{
    internal static class Program
    {
        /// <summary>
        ///     アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Bootstrap.Run();
        }
    }
}
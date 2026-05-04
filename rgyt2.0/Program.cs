using rgyt2._0.Database;
using rgyt2._0.Forms;
using rgyt2._0.Models;
using rgyt2._0.Services;

namespace rgyt2._0
{
    internal static class Program
    {


        public static ConfigService Config { get; private set; } = new();
        public static DbfContext DbfContext { get; private set; } = null!;
        public static SQLiteDbContext SqliteContext { get; private set; } = null!;
        public static AuthService AuthService { get; private set; } = null!;

        public static User? CurrentUser { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Config.Load();

            DbfContext = new DbfContext(Config.Config.Database.DbfFolder);
            SqliteContext = new SQLiteDbContext(Config.Config.Database.SqliteFile);
            AuthService = new AuthService(SqliteContext);


            using var loginForm = new LoginForm();

            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new MainForm());

        }

    }
}
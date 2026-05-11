using rgyt2._0.Database;
using rgyt2._0.Forms;
using rgyt2._0.Models;
using rgyt2._0.Services;
using System.Diagnostics;

namespace rgyt2._0
{
    internal static class Program
    {
        public static ConfigService Config { get; private set; } = new();
        public static DbfContext DbfContext { get; set; } = null!;
        public static SQLiteDbContext SqliteContext { get; private set; } = null!;
        public static AuthService AuthService { get; private set; } = null!;
        public static User? CurrentUser { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Config.Load();

            string dbfFolder = Config.Settings.Database.DbfFolder;
            string sqliteFile = Config.Settings.Database.SqliteFile;

            // ✅ SQLITE ellenőrzés → KÖTELEZŐ
            if (!File.Exists(sqliteFile))
            {
                MessageBox.Show(
                    $"Az SQLite adatbázis nem található:\n{sqliteFile}\n\nAz alkalmazás bezáródik.",
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // ✅ DBF mappa ellenőrzés → NEM kötelező
            bool dbfAvailable = Directory.Exists(dbfFolder);

            if (!dbfAvailable)
            {
                MessageBox.Show(
                    $"A DBF mappa nem található:\n{dbfFolder}\n\nAz alkalmazás elindul, de DBF adatok nem lesznek elérhetők.",
                    "Figyelmeztetés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                // ✅ csak ha van DBF
                EnsurePythonDbfModule();
                RunPythonFilter(dbfFolder);
            }

            // ✅ Kontextusok
            DbfContext = new DbfContext(dbfFolder);
            SqliteContext = new SQLiteDbContext(sqliteFile);
            AuthService = new AuthService(SqliteContext);

            using var loginForm = new LoginForm();

            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new MainForm());
        }

        private static void RunPythonFilter(string dbfFolder)
        {
            var exeDir = AppDomain.CurrentDomain.BaseDirectory;
            var scriptPath = Path.Combine(exeDir, "filter.py");

            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c python \"{scriptPath}\" \"{dbfFolder}\"",
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(psi)?.WaitForExit();
        }

        private static void EnsurePythonDbfModule()
        {
            var check = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "-c \"import dbf\"",
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(check);
            process!.WaitForExit();

            if (process.ExitCode != 0)
            {
                MessageBox.Show(
                    "A szükséges Python 'dbf' modul nincs telepítve.\nTelepítés indul...",
                    "Python modul hiányzik",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                var install = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = "-m pip install dbf",
                    UseShellExecute = true,
                    CreateNoWindow = false
                };

                Process.Start(install)?.WaitForExit();
            }
        }
    }
}

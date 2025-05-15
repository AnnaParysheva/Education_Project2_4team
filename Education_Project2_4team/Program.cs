using System;
using System.Threading;
using System.Windows.Forms;
using NLog;
using SQLitePCL;

namespace Education_Project2_4team
{
    internal static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EnsureAdminExists();
            Batteries.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
            // Регистрация обработчиков необработанных исключений
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            try
            {
                Logger.Info("Запуск приложения");
                Application.Run(new Authorization());
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex, "Критическая ошибка приложения");
                MessageBox.Show("Произошла критическая ошибка. Приложение будет закрыто.");
            }
        }
        static void EnsureAdminExists()
        {
            using (var db = new UsersContext())
            {
                db.Database.EnsureCreated();
                var admin = new Users
                {
                    Name = "Admin",
                    Surname = "System",
                    Login = "admin",
                    Password = Registration.HashPassword("admin")
                };
                db.Users.Add(admin);
                db.SaveChanges();
            }

        }
        /// <summary>
        /// Обработчик необработанных исключений в UI потоке
        /// </summary>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Logger.Error(e.Exception, "Необработанное исключение в UI потоке");
        }

        /// <summary>
        /// Обработчик необработанных исключений в домене приложения
        /// </summary>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Logger.Fatal(e.ExceptionObject as Exception, "Необработанное исключение в домене приложения");
        }
    }
}
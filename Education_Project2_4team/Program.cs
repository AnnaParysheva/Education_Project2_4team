using System;
using System.Windows.Forms;
using SQLitePCL;

namespace Education_Project2_4team
{
    internal static class Program
    {
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
    }
}
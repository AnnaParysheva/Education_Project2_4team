using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
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
            using (var db = new UsersContext(new DbContextOptions<UsersContext>()))
            {
                var admin = new Users
                {
                    Name = "Admin",
                    Surname = "System",
                    Login = "admin",
                    Password = "admin"
                };
                db.Users.Add(admin);
                db.SaveChanges();
            }

        }
    }
}
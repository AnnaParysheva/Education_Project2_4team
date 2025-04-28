using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    public partial class Authorization : Form
    {
        ApplicationContext db;
        public event Action<User> UserSaved;
        public Authorization()
        {
            InitializeComponent();
            db = new ApplicationContext();
            this.txtBoxPassword.AutoSize = false;
            this.txtBoxPassword.Size = new Size(this.txtBoxPassword.Size.Width,50);
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //var login = txtBoxLogin.Text;
            //var password = txtBoxLogin.Text;
            //User user = new User("Anya", "Parysheva", login, password, "@");
            //db.Users.Add(user);
            //db.SaveChanges();
            //using (var db = new ApplicationContext())
            //{
            //    db.Users.Add();
            //    db.SaveChanges();
            //    MessageBox.Show("Пользователь добавлен!");
            //}
            try
            {
                var newUser = new User
                {
                    name = "Anya",
                    surname = "Parysheva",
                    login = txtBoxLogin.Text,
                    password = txtBoxPassword.Text,  // Исправлено!
                    email = "@"
                };

                db.Users.Add(newUser);  // Используем существующий db из конструктора
                db.SaveChanges();
                UserSaved?.Invoke(newUser);

                MessageBox.Show("Пользователь сохранён!");
                this.Close();
            }
            catch (Exception ex)  // Добавьте вывод ошибки для отладки
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

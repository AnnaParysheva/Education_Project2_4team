using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SQLite;
using Education_Project2_4team;

namespace Education_Project2_4team
{
    public partial class Registration : Form
    {
        //ApplicationContext db;
        public Registration()
        {
            InitializeComponent();
            //db = new ApplicationContext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            var name = txtBoxName.Text.Trim();
            var surname= txtBoxSurname.Text.Trim();
            var login= txtBoxLogin.Text.Trim();
            var password= txtBoxPassword.Text.Trim();
            var passRepeat= txtBoxPassRepeat.Text.Trim();
            if (login.Length < 4)
            {
                MessageBox.Show("Логин должен содержать не менее 4 символов");
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов");
            }
            if (password != passRepeat)
            {
                MessageBox.Show("Пароли не совпадают");
            }
        //    try
        //    {
        //        using (var db = new UsersContext())
        //        {
        //            var user = new User
        //            {
        //                Name = name,
        //                Surname = surname,
        //                Login = login,
        //                Password = password  
        //            };

        //            db.Users.Add(user);
        //            db.SaveChanges();
        //            MessageBox.Show("Регистрация успешна!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка: {ex.Message}");
        //    }
        }
    }
}

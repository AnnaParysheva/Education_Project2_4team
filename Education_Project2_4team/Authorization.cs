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
using Education_Project2_4team;
using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team
{
    public partial class Authorization : Form
    {
        public Users CurrentUser { get; private set; }
        public Authorization()
        {
            InitializeComponent();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var login = txtBoxLogin.Text.Trim();
            var password = txtBoxPassword.Text.Trim();

            try
            {
                using (var db = new UsersContext(new DbContextOptions<UsersContext>()))
                {
                    var auth = new AuthorizationUsing(db);
                    var user = auth.ValidateUser(login, password);

                    if (user != null)
                    {
                        CurrentUser = user;
                        this.DialogResult = DialogResult.OK;
                        var questionnaireForm = new questionnare(user.Id);
                        this.Hide();
                        questionnaireForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            var registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void btnLogInAsAnAdministrator_Click(object sender, EventArgs e)
        {
            var login = txtBoxLogin.Text.Trim();
            var password = txtBoxPassword.Text.Trim();

            try
            {
                using (var db = new UsersContext(new DbContextOptions<UsersContext>()))
                {
                    var auth = new AuthorizationUsing(db);
                    if (auth.IsAdmin(login, password))
                    {
                        var questionnaireForm = new CoursesForm(false);
                        this.Hide();
                        questionnaireForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }
    }
}

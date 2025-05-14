using System;
using System.Linq;
using System.Windows.Forms;

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
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            var hashedPassword = Registration.HashPassword(password);
            try
            {
                using (var db = new UsersContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == hashedPassword);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
            }
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
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            var hashedPassword = Registration.HashPassword(password);
            try
            {
                using (var db = new UsersContext())
                {
                    var admin = db.Users.FirstOrDefault(u => u.Login == "admin" && u.Password == hashedPassword);
                    if (admin!=null)
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

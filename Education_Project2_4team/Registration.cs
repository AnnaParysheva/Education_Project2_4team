using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    public partial class Registration : Form
    {
        public event Action<Users> UserSaved;
        public Registration()
        {
            InitializeComponent();
        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private bool IsEnglishLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            var name = txtBoxName.Text.Trim();
            var surname = txtBoxSurname.Text.Trim();
            var login = txtBoxLogin.Text.Trim();
            var password = txtBoxPassword.Text.Trim();
            var passRepeat = txtBoxPassRepeat.Text.Trim();

            try
            {
                using (var db = new UsersContext(new DbContextOptions<UsersContext>()))
                {
                    db.Database.EnsureCreated();

                    var registration = new RegistrationUsing(db);
                    var result = registration.Register(name, surname, login, password, passRepeat);

                    if (result == "Регистрация успешна")
                    {
                        UserSaved?.Invoke(new Users
                        {
                            Name = name,
                            Surname = surname,
                            Login = login,
                            Password = password
                        });

                        MessageBox.Show(result);
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void checkBoxRepeatPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassRepeat.PasswordChar = checkBoxRepeatPassword.Checked ? '\0' : '•';
        }
    }
}

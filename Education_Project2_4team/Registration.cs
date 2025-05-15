using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    /// <summary>
    /// Форма регистрации нового пользователя
    /// </summary>
    public partial class Registration : Form
    {
        /// <summary>
        /// Событие, вызываемое после успешной регистрации
        /// </summary>
        public event Action<Users> UserSaved;
        /// <summary>
        /// Конструктор формы регистрации
        /// </summary>
        public Registration()
        {
            InitializeComponent();
            this.Text = RegistrationResource.RegistrationTitle;
            label1.Text = RegistrationResource.RegistrationTitle;
            label2.Text = RegistrationResource.LabelLogin;
            label3.Text = RegistrationResource.LabelPassword;
            label4.Text = RegistrationResource.LabelRepeatPassword;
            label5.Text = RegistrationResource.LabelName;
            label6.Text = RegistrationResource.LabelSurname;
            btnRegistration.Text = RegistrationResource.ButtonRegister;
            checkBoxShowPassword.Text = RegistrationResource.CheckBoxShowPassword;
            checkBoxRepeatPassword.Text = RegistrationResource.CheckBoxShowRepeatPassword;
        }
        public static string HashPassword(string password)
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
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(RegistrationResource.Error_EmptyName,
                              RegistrationResource.RegistrationTitle);
                return;
            }

            if (string.IsNullOrEmpty(surname))
            {
                MessageBox.Show(RegistrationResource.Error_EmptySurname,
                              RegistrationResource.RegistrationTitle);
                return;
            }

            if (login.Length < 4)
            {
                MessageBox.Show(RegistrationResource.Error_ShortLogin,
                              RegistrationResource.RegistrationTitle);
                return;
            }

            if (!IsEnglishLetters(login))
            {
                MessageBox.Show(RegistrationResource.Error_InvalidLogin,
                              RegistrationResource.RegistrationTitle);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show(RegistrationResource.Error_ShortPassword,
                              RegistrationResource.RegistrationTitle);
                return;
            }

            if (password != passRepeat)
            {
                MessageBox.Show(RegistrationResource.Error_PasswordsDoNotMatch,
                              RegistrationResource.RegistrationTitle);
                return;
            }
            try
            {
                using (var db = new UsersContext())
                {
                    db.Database.EnsureCreated();
                    var user = new Users
                    {
                        Name = name,
                        Surname = surname,
                        Login = login,
                        Password = HashPassword(password)
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                    UserSaved?.Invoke(user);
                    MessageBox.Show(RegistrationResource.Success_Registration,
                                  RegistrationResource.RegistrationTitle);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(RegistrationResource.Error_Generic, ex.Message),
                              RegistrationResource.RegistrationTitle);
            }
        }
        private void checkBoxRepeatPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassRepeat.PasswordChar = checkBoxRepeatPassword.Checked ? '\0' : '•';
        }
    }
}

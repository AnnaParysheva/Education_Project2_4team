using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            var name = txtBoxName.Text.Trim();
            var surname = txtBoxSurname.Text.Trim();
            var login = txtBoxLogin.Text.Trim();
            var password = txtBoxPassword.Text.Trim();
            var passRepeat = txtBoxPassRepeat.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Поле 'Имя' не должно быть пустым");
            }
            if (surname.Length == 0)
            {
                MessageBox.Show("Поле 'Фамилия' не должно быть пустым");
            }
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
                        Password = password
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                    UserSaved?.Invoke(user);
                    MessageBox.Show("Регистрация успешна!");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}

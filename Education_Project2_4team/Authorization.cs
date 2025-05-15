using System;
using System.Linq;
using System.Windows.Forms;
using Education_Project2_4team.Properties;
using NLog;

namespace Education_Project2_4team
{
    /// <summary>
    /// Форма авторизации пользователей в системе
    /// </summary>
    public partial class Authorization : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Текущий авторизованный пользователь
        /// </summary>
        public Users CurrentUser { get; private set; }
        /// <summary>
        /// Инициализирует новый экземпляр формы авторизации
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
            this.Text = AuthorizationResource.FormTitleAuthorization;
            label_Authorization.Text = AuthorizationResource.LabelAuthorizationText;
            textBox1.Text = AuthorizationResource.LoginLabelText;
            textBox2.Text = AuthorizationResource.PasswordLabelText;
            btnEnter.Text = AuthorizationResource.ButtonEnterText;
            btnLogInAsAnAdministrtion.Text = AuthorizationResource.ButtonAdminText;
            btn_register.Text = AuthorizationResource.ButtonRegisterText;
            checkBoxShowPassword.Text = AuthorizationResource.CheckBoxShowPasswordText;
            Logger.Info("Форма авторизации инициализирована");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Logger.Debug("Попытка входа как обычный пользователь...");
            var login = txtBoxLogin.Text.Trim();
            var password = txtBoxPassword.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                Logger.Warn("Введен пустой логин или пароль");
                MessageBox.Show(AuthorizationResource.LoginPrompt, AuthorizationResource.LabelAuthorizationText);
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
                        Logger.Info($"Пользователь {login} успешно авторизован");
                        CurrentUser = user;
                        this.DialogResult = DialogResult.OK;
                        var questionnaireForm = new questionnare(user.Id);
                        this.Hide(); 
                        questionnaireForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Logger.Warn($"Неудачная попытка входа для пользователя {login}");
                        MessageBox.Show(AuthorizationResource.LoginFailed, AuthorizationResource.LabelAuthorizationText);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"Ошибка авторизации для пользователя {login}");
                MessageBox.Show(string.Format(AuthorizationResource.AuthorizationError, ex.Message),
                              AuthorizationResource.LabelAuthorizationText);
            }
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            Logger.Info("Открытие формы регистрации");
            var registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void btnLogInAsAnAdministrator_Click(object sender, EventArgs e)
        {
            Logger.Debug("Попытка входа как администратор...");
            var login = txtBoxLogin.Text.Trim();
            var password = txtBoxPassword.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                Logger.Warn("Введен пустой логин или пароль для администратора");
                MessageBox.Show(AuthorizationResource.LoginPrompt, AuthorizationResource.LabelAuthorizationText);
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
                        Logger.Info("Администратор успешно авторизован");
                        var questionnaireForm = new CoursesForm(false);
                        this.Hide();
                        questionnaireForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Logger.Warn($"Неудачная попытка входа администратора (логин: {login})");
                        MessageBox.Show(AuthorizationResource.LoginFailed, AuthorizationResource.LabelAuthorizationText);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ошибка авторизации администратора");
                MessageBox.Show(string.Format(AuthorizationResource.AuthorizationError, ex.Message),
                              AuthorizationResource.LabelAuthorizationText);
            }
            
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            Logger.Trace($"Видимость пароля изменена на {checkBoxShowPassword.Checked}");
            txtBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }
    }
}

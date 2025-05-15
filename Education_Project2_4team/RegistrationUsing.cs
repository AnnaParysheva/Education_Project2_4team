using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Education_Project2_4team
{
    public class RegistrationUsing
    {
        private readonly UsersContext Context;

        public RegistrationUsing(UsersContext context)
        {
            Context = context;
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

        public string Register(string name, string surname, string login, string password, string passRepeat)
        {
            if (name.Length == 0)
                return "Поле 'Имя' не должно быть пустым";

            if (surname.Length == 0)
                return "Поле 'Фамилия' не должно быть пустым";

            if (login.Length < 4)
                return "Логин должен содержать не менее 4 символов";

            if (!IsEnglishLetters(login))
                return "Логин должен содержать только английские буквы";

            if (password.Length < 8)
                return "Пароль должен содержать не менее 8 символов";

            if (password != passRepeat)
                return "Пароли не совпадают";

            var user = new Users
            {
                Name = name,
                Surname = surname,
                Login = login,
                Password = HashPassword(password)
            };

            Context.Users.Add(user);
            Context.SaveChanges();

            return "Регистрация успешна";
        }

    }
}

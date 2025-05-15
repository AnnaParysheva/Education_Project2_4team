using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Project2_4team
{
        public class AuthorizationUsing
        {
            private readonly UsersContext Context;

            public AuthorizationUsing(UsersContext context)
            {
                Context = context;
            }

            public Users ValidateUser(string login, string password)
            {
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                    throw new ArgumentException("Введите логин и пароль");

                try
                {
                    return Context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка при проверке пользователя: {ex.Message}");
                }
            }

            public bool IsAdmin(string login, string password)
            {
                return login == "admin" && password == "admin";
            }
        }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Project2_4team
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        //public User() { }
        //public User(string name, string surname, string login, string password)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Login = login;
        //    Password = password;
        //}
    }
}

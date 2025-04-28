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
        [Key]
        public int id { get; set; }  
        public string name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        //public User() { }
        //public User(string name, string surname, string login, string password, string email)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.login = login;
        //    this.password = password;
        //    this.email = email;
        //}
    }
}

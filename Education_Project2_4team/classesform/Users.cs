using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Education_Project2_4team
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Favourites> Favourites { get; set; } = new List<Favourites>();
    }
}

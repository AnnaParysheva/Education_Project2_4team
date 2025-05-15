using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education_Project2_4team
{
    public class Favourites
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        [ForeignKey("Courses")]
        public int IDCourses { get; set; }
        public Users User { get; set; }
        public Courses Course { get; set; }
    }
}

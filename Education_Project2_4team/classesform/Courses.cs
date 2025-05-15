using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Education_Project2_4team
{
    public class Courses
    {
        [Key]
        public int IDCourses { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public string LevelOfPreparation { get; set; }
        public string EducationalForm { get; set; }
        public List<Favourites> Favourites { get; set; } = new List<Favourites>();
    }
}

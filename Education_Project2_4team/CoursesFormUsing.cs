using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Education_Project2_4team
{ 
     public class CoursesFormUsing
     {
            private readonly CoursesContext CoursesContext;
            private readonly FavouritesContext FavouritesContext;

            public CoursesFormUsing()
            {
                CoursesContext = new CoursesContext();
                FavouritesContext = new FavouritesContext();
            }

            public CoursesFormUsing(CoursesContext testCourses, FavouritesContext testFavourites)
            {
                CoursesContext = testCourses;
                FavouritesContext = testFavourites;
            }

            public List<Courses> GetAllCourses()
            {
                return CoursesContext.Courses.ToList();
            }

            public List<Courses> FilterByCategory(string category)
            {
                if (category == "Все категории")
                    return GetAllCourses();

                return CoursesContext.Courses.Where(c => c.Category == category).ToList();
            }

            public Courses GetCourseDetails(int id)
            {
                return CoursesContext.Courses.FirstOrDefault(c => c.IDCourses == id);
            }

            public bool DeleteCourse(int courseId)
            {
                var course = CoursesContext.Courses.Find(courseId);
                if (course != null)
                {
                    CoursesContext.Courses.Remove(course);
                    CoursesContext.SaveChanges();
                    return true;
                }
                return false;
            }

            public bool AddToFavourites(int userId, int courseId)
            {
                bool exists = FavouritesContext.Favourites
                    .Any(f => f.UserId == userId && f.IDCourses == courseId);

                if (exists)
                    return false;

                FavouritesContext.Favourites.Add(new Favourites
                {
                    UserId = userId,
                    IDCourses = courseId
                });
                FavouritesContext.SaveChanges();
                return true;
            }

            public List<Courses> RecommendCourses(string selectedCategory, string selectedForm, string selectedLevel, string selectedDuration)
            {
                double categoryWeight = 0.5;
                double levelWeight = 0.3;
                double formWeight = 0.1;
                double durationWeight = 0.1;

                var allCourses = CoursesContext.Courses.ToList();

                var scoredCourses = allCourses.Select(course =>
                {
                    double score = 0;

                    if (course.Category == selectedCategory)
                        score += categoryWeight;
                    if (course.EducationalForm == selectedForm)
                        score += formWeight;
                    if (course.LevelOfPreparation == selectedLevel)
                        score += levelWeight;
                    if (course.Duration == selectedDuration)
                        score += durationWeight;

                    return new { Course = course, Score = score };
                });

                return scoredCourses
                    .Where(x => x.Score >= 0.6)
                    .OrderByDescending(x => x.Score)
                    .Select(x => x.Course)
                    .ToList();
            }
     }
}


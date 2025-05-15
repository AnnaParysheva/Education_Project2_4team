using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Project2_4team
{
    public class AddCourseUsing
    {
        private readonly CoursesContext Context;

        public AddCourseUsing(CoursesContext context)
        {
            Context = context;
        }

        public Courses AddCourse(Courses course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
            return course;
        }

        public Courses UpdateCourse(int courseId, Courses updatedCourse)
        {
            var existingCourse = Context.Courses.FirstOrDefault(c => c.IDCourses == courseId);
            if (existingCourse == null)
                return null;

            existingCourse.Title = updatedCourse.Title;
            existingCourse.Duration = updatedCourse.Duration;
            existingCourse.Category = updatedCourse.Category;
            existingCourse.Description = updatedCourse.Description;
            existingCourse.LevelOfPreparation = updatedCourse.LevelOfPreparation;
            existingCourse.EducationalForm = updatedCourse.EducationalForm;

            Context.SaveChanges();
            return existingCourse;
        }
    }
}
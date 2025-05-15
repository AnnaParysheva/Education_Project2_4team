using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Education_Project2_4team.Test;

[TestClass]
public class AddCourseTests
{
    [TestMethod]
    public void AddCourse_RightInfo_ReturnsSuccess()
    {
        var options = new DbContextOptionsBuilder<CoursesContext>()
            .UseInMemoryDatabase("AddCourseTestDB").Options;

        using (var context = new CoursesContext(options))
        {
            var service = new AddCourseUsing(context);
            var course = new Courses
            {Title = "Piano Course",Duration = "2 month", Category = "Music",Description = "Learning basic instrument playing",LevelOfPreparation = "Basic", EducationalForm = "Online"};
            var result = service.AddCourse(course);
            Assert.IsNotNull(result);
            Assert.AreEqual("Piano Course", result.Title);
            Assert.AreEqual(1, context.Courses.Count());
        }
    }
}
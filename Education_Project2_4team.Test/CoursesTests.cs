using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team.Test;

[TestClass]
public class CoursesTests
{
    [TestMethod]
    public void RecommendCourses_NullInfo_ReturnsEmpty()
    {
        var coursesOptions = new DbContextOptionsBuilder<CoursesContext>()
            .UseInMemoryDatabase("MistakeForRecommendCourses").Options;
        var favouritesOptions = new DbContextOptionsBuilder<FavouritesContext>()
            .UseInMemoryDatabase("MistakeForRecommendCourses").Options;
        using (var coursesContext = new CoursesContext(coursesOptions))
        using (var favouritesContext = new FavouritesContext(favouritesOptions))
        { //arrange
            coursesContext.Courses.Add(new Courses
            {Category = "Music",EducationalForm = "Intramural",LevelOfPreparation = "Beginner",Duration = "2 weeks"});
            coursesContext.SaveChanges();
            var coursesUsing = new CoursesFormUsing(coursesContext, favouritesContext);
            //act
            var result = coursesUsing.RecommendCourses(null, null, null, null);
            //assert
            Assert.AreEqual(0, result.Count);
        }
    }
    [TestMethod]
    public void RecommendCourses_RightInfo_ReturnsSuccess()
    {
        var coursesOptions = new DbContextOptionsBuilder<CoursesContext>()
            .UseInMemoryDatabase("RightForRecommendCourses").Options;
        var favouritesOptions = new DbContextOptionsBuilder<FavouritesContext>()
            .UseInMemoryDatabase("RightForRecommendCourses").Options;
        using (var coursesContext = new CoursesContext(coursesOptions))
        using (var favouritesContext = new FavouritesContext(favouritesOptions))
        {
            //arrange
            coursesContext.Courses.Add(new Courses
            { Category = "Music", EducationalForm = "Intramural", LevelOfPreparation = "Beginner", Duration = "2 weeks" });
            coursesContext.Courses.Add(new Courses
            { Category = "Music", EducationalForm = "Intramural", LevelOfPreparation = "Beginner", Duration = "2 weeks" });
            coursesContext.SaveChanges();
            var coursesUsing = new CoursesFormUsing(coursesContext, favouritesContext);
            //act
            var result = coursesUsing.RecommendCourses("Music", "Intramural", "Beginner", "2 weeks");
            //assert
            Assert.IsTrue(result.Count > 0);
            Assert.AreEqual("Music", result[0].Category);
            Assert.AreEqual("Intramural", result[0].EducationalForm);
            Assert.AreEqual("Beginner", result[0].LevelOfPreparation);
            Assert.AreEqual("2 weeks", result[0].Duration);
        }
    }


}





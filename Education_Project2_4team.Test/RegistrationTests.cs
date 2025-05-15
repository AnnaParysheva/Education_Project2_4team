using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team.Test;

[TestClass]
public class RegistrationTests
{
    [TestMethod]

    public void RegistrationUser_CorrectInfo_ReturnSuccessfulRegistration()
    {
       var options = new DbContextOptionsBuilder<UsersContext>()
       .UseInMemoryDatabase("RegistrationSuccess").Options;

        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("Sofya", "Merkulova", "sonya", "password", "password");
            // assert
            Assert.AreEqual("Регистрация успешна", result);
        }
    }
    [TestMethod]
    public void IsCorrectPassword_ShortPassword_ReturnMistake()
    {
        var options = new DbContextOptionsBuilder<UsersContext>()
        .UseInMemoryDatabase("RegistrationSuccess").Options;

        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("Sofya", "Merkulova", "sonya", "pass", "pass");
            // assert
            Assert.AreEqual("Пароль должен содержать не менее 8 символов", result);
        }
    }
    [TestMethod]
    public void IsCorrectLogin_ShortLogin_ReturnMistake()
    {
        var options = new DbContextOptionsBuilder<UsersContext>()
        .UseInMemoryDatabase("RegistrationSuccess").Options;

        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("Sofya", "Merkulova", "sof", "password", "password");
            // assert
            Assert.AreEqual("Логин должен содержать не менее 4 символов", result);
        }
    }
    [TestMethod]
    public void IsEnglishLetters_RusLogin_ReturnMistake()
    {
        var options = new DbContextOptionsBuilder<UsersContext>()
        .UseInMemoryDatabase("RegistrationSuccess").Options;

        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("Sofya", "Merkulova", "Софья", "password", "password");
            // assert
            Assert.AreEqual("Логин должен содержать только английские буквы", result);
        }
    }
    [TestMethod]
    public void RegistrationUser_NoName_ReturnMistake()
    {
        var options = new DbContextOptionsBuilder<UsersContext>()
        .UseInMemoryDatabase("RegistrationSuccess").Options;

        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("", "Merkulova", "sofya", "password", "password");
            // assert
            Assert.AreEqual("Поле 'Имя' не должно быть пустым", result);
        }
    }
    [TestMethod]
    public void RegistrationUser_NoSurname_ReturnMistake()
    {
        var options = new DbContextOptionsBuilder<UsersContext>()
        .UseInMemoryDatabase("RegistrationSuccess").Options;

        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("Sofya", "", "sofya", "password", "password");
            // assert
            Assert.AreEqual("Поле 'Фамилия' не должно быть пустым", result);
        }
    }
    [TestMethod]
    public void RegistrationUser_WrongPasswods_ReturnMistake()
    {
        var options = new DbContextOptionsBuilder<UsersContext>()
        .UseInMemoryDatabase("RegistrationSuccess").Options;
        using (var context = new UsersContext(options))
        {
            // arrange
            var registration = new RegistrationUsing(context);
            // act
            var result = registration.Register("Sofya", "Merkulova", "sofya", "password", "pass");
            // assert
            Assert.AreEqual("Пароли не совпадают", result);
        }
    }

}

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
            Assert.AreEqual("����������� �������", result);
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
            Assert.AreEqual("������ ������ ��������� �� ����� 8 ��������", result);
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
            Assert.AreEqual("����� ������ ��������� �� ����� 4 ��������", result);
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
            var result = registration.Register("Sofya", "Merkulova", "�����", "password", "password");
            // assert
            Assert.AreEqual("����� ������ ��������� ������ ���������� �����", result);
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
            Assert.AreEqual("���� '���' �� ������ ���� ������", result);
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
            Assert.AreEqual("���� '�������' �� ������ ���� ������", result);
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
            Assert.AreEqual("������ �� ���������", result);
        }
    }

}

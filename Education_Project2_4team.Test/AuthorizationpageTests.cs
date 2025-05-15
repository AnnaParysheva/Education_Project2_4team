using Microsoft.EntityFrameworkCore;
namespace Education_Project2_4team.Tests
{
    [TestClass]
    public sealed class AuthorizationpageTests
    {
        [TestMethod]
        public void EntryAttempt_TheCorrectUser_ReturnTheName()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
           .UseInMemoryDatabase("TestRightUser").Options;
            using (var context = new UsersContext(options))
            {
                //arrange
                var testUser = new Users { Login = "sonya", Password = "merk" };
                context.Users.Add(testUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                //act
                var result = auth.ValidateUser("sonya", "merk");
                //assert
                Assert.IsNotNull(result);
                Assert.AreEqual("sonya", result.Login);
            }

        }
        [TestMethod]
        public void EntryAttempt_WrongUser_ReturnTheWarning()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
           .UseInMemoryDatabase("TestWrongUser").Options;
            using (var context = new UsersContext(options))
            {
                //arrange
                var testUser = new Users { Login = "sonya", Password = "merk" };
                context.Users.Add(testUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                //act
                var result = auth.ValidateUser("sonyy", "merr");
                //assert
                Assert.IsNull(result);
            }


        }
        [TestMethod]
        public void EnterAdmin_CorrectInformation_ReturnsTrue()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseInMemoryDatabase("CorrectAdmin").Options;

            using (var context = new UsersContext(options))
            {
                // arrange
                var adminUser = new Users { Login = "admin", Password = "admin" };
                context.Users.Add(adminUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                // act
                var result = auth.IsAdmin("admin", "admin");
                // assert
                Assert.IsTrue(result);
            }
        }
        [TestMethod]
        public void EnterAdmin_WrongInformation_ReturnsFalse()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseInMemoryDatabase("WrongAdmin").Options;

            using (var context = new UsersContext(options))
            {
                // arrange
                var adminUser = new Users { Login = "adminn", Password = "admiin" };
                context.Users.Add(adminUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                // act
                var result = auth.IsAdmin("adminn", "admiin");
                // assert
                Assert.IsFalse(result);
            }
        }
        [TestMethod]
        public void EntryAttempt_WrongLogin_ReturnsNull()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseInMemoryDatabase("CorrectPasswordWrongLoginDB").Options;

            using (var context = new UsersContext(options))
            {
                // arrange
                var testUser = new Users { Login = "sonya", Password = "passed" };
                context.Users.Add(testUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                //act
                var result = auth.ValidateUser("sonnnnn", "passed");
                //assert
                Assert.IsNull(result);
            }
        }
        [TestMethod]
        public void EnterAdmin_WrongLogin_ReturnsFalse()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseInMemoryDatabase("WrongAdmin").Options;

            using (var context = new UsersContext(options))
            {
                // arrange
                var adminUser = new Users { Login = "adminn", Password = "admin" };
                context.Users.Add(adminUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                // act
                var result = auth.IsAdmin("adminn", "admin");
                // assert
                Assert.IsFalse(result);
            }
        }
        [TestMethod]
        public void EnterAdmin_WrongPassword_ReturnsFalse()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseInMemoryDatabase("WrongAdmin").Options;

            using (var context = new UsersContext(options))
            {
                // arrange
                var adminUser = new Users { Login = "admin", Password = "admiin" };
                context.Users.Add(adminUser);
                context.SaveChanges();
                var auth = new AuthorizationUsing(context);
                // act
                var result = auth.IsAdmin("admin", "admiin");
                // assert
                Assert.IsFalse(result);
            }
        }

    }
}


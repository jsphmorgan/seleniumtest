using NUnit.Framework;
namespace seleniumTests {
    public class LoginTests : BaseTest {
        private static string goodUsername = "standard_user";
        private static string lockedOutUser = "locked_out_user";
        private static string problemUser = "problem_user";
        private static string password = "secret_sauce";
        private static string successImageString = "/static/media/sauce-backpack-1200x1500.34e7aa42.jpg";
        private static string lockedOutError = "Epic sadface: Sorry, this user has been locked out.";
        private static string badImageString = "/static/media/sl-404.168b1cce.jpg";

        LoginService login = new LoginService();

        [Test]
        public void successfulLogin()
        {
            string validationText;
            validationText = login.login(driver, goodUsername, password, false);
            StringAssert.Contains(successImageString, validationText);
        }

        [Test]
        public void problemUserTest() {
            string validationText;
            validationText = login.login(driver, problemUser, password, false);
            StringAssert.Contains(badImageString, validationText);
        }

        [Test]
        public void lockedOutTest() {
            string validationText;
            validationText = login.login(driver, lockedOutUser, password, true);
            StringAssert.AreEqualIgnoringCase(lockedOutError, validationText);
        }
    }
}

using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace seleniumTests {
    public class LoginTests {
        private static string goodUsername = "standard_user";
        private static string lockedOutUser = "locked_out_user";
        private static string problemUser = "problem_user";
        private static string password = "secret_sauce";

        LoginService login = new LoginService();
        IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));


        [Fact]
        public void successfulLogin()
        {
            login.login(driver, goodUsername, password);
        }
    }
}
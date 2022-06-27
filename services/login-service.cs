namespace seleniumTests {
    public class LoginService {
        public void login(IWebDriver driver, string userName, string password) {
            Loginpageobjects objects = new Loginpageobjects();
            driver.Navigate().GoToUrl("https://saucedemo.com");
            objects.userName.SendKeys(userName);
            objects.password.SendKeys(password);
            objects.loginButton.Click();
        }
    }
}
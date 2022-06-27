using OpenQA.Selenium;

namespace seleniumTests {
    public class LoginService {
        public void login(IWebDriver driver, string userName, string password) {
            Loginpageobjects objects = new Loginpageobjects();
            driver.Navigate().GoToUrl("https://saucedemo.com");
            objects.userName(driver).SendKeys(userName);
            objects.password(driver).SendKeys(password);
            objects.loginButton(driver).Click();
        }
    }
}
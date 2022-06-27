using OpenQA.Selenium;

namespace seleniumTests
{
    public class Loginpageobjects
    {
        public IWebElement userName(IWebDriver driver) {
            return driver.FindElement(By.Id("user-name"));
        }

        public IWebElement password(IWebDriver driver) {
            return driver.FindElement(By.Id("password"));
        }

        public IWebElement loginButton(IWebDriver driver) {
            return driver.FindElement(By.Id("login-button"));
        }

        public IWebElement errorContainer(IWebDriver driver) {
            return driver.FindElement(By.CssSelector("error"));
        }
    }
}
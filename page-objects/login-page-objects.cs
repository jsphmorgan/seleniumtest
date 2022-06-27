namespace seleniumTests
{
    public class Loginpageobjects
    {
        public IWebElement userName(IWebDriver driver) {
            return driver.FindElement(By.id("user-name"));
        }

        public IWebElement password(IWebDriver driver) {
            return driver.FindElement(By.id("password"));
        }

        public IWebElement loginButton(IWebDriver driver) {
            return driver.FindElement(By.id("login-button"));
        }

        public IWebElement errorContainer(IWebDriver driver) {
            return driver.FindElement(By.css("error"));
        }
    }
}
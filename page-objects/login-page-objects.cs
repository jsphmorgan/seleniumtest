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

        public IWebElement validationIdentifier(IWebDriver driver, bool error) {
            if(error) {
                return driver.FindElement(By.CssSelector("[data-test=error]"));
            }
            else {
                return driver.FindElement(By.Id("item_4_img_link"));
            }
            
        }
    }
}
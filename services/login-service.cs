using OpenQA.Selenium;

namespace seleniumTests {
    public class LoginService {
        public string validationText;
        public string login(IWebDriver driver, string userName, string password, bool error) {
            Loginpageobjects objects = new Loginpageobjects();
            driver.Navigate().GoToUrl("https://saucedemo.com");
            objects.userName(driver).SendKeys(userName);
            objects.password(driver).SendKeys(password);
            objects.loginButton(driver).Click();
            if(error) {
                validationText = objects.validationIdentifier(driver, error).Text;
            }
            else {
                validationText = objects.validationIdentifier(driver, error).FindElement(By.ClassName("inventory_item_img")).GetAttribute("src");
            }
            return validationText;
        }
    }
}
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumTests
{
    public class BaseTest {
        public IWebDriver driver;
        [SetUp]
        
        public void BaseSetup() {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("https://saucedemo.com");
        }

        [TearDown]
        public void TearDown() {
            driver.Quit();
        }
    }
}
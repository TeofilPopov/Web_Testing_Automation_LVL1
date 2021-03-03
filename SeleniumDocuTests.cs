using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverExample.Pages;

namespace WebDriverExample
{
    [TestFixture]
    public class SeleniumDocuTests
    {
        private IWebDriver _driver;
        private SeleniumDocuMainPage _seleniumDocuMainPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _seleniumDocuMainPage = new SeleniumDocuMainPage(_driver);
            _driver.Url = "https://www.selenium.dev/documentation/en/getting_started/";
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void Components_Page_Is_Loaded()
        {
            _seleniumDocuMainPage.ClickGridInSidebar();
            _seleniumDocuMainPage.Click_Grid3_Components_In_Sidebar();
            var actualPage = WaitAndFindElement(By.XPath("//h1[contains(text(),'Components')]"));

            Assert.IsTrue(actualPage.Displayed);
        }

        [Test]
        public void Github_Page_Is_Loaded()
        {
            _seleniumDocuMainPage.Click_GitHub_In_Sidebar();
            var actualPage = WaitAndFindElement(By.XPath("//span[contains(text(),'Code')]"));

            Assert.IsTrue(actualPage.Displayed);
        }

        private IWebElement WaitAndFindElement(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }
    }
}
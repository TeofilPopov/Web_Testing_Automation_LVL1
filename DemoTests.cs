using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverExample.Pages;

namespace WebDriverExample
{
    [TestFixture]
    public class DemoTests
    {
        private IWebDriver _driver;
        private MainPage _mainPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            var options = new ChromeOptions();
            options.AddArguments("headless");
            _mainPage = new MainPage(_driver);
            _driver.Url = "http://demos.bellatrix.solutions/";
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void CorrectPageWasLoaded()
        {
            Assert.AreEqual("http://demos.bellatrix.solutions/", _driver.Url);
        }

        [Test]
        public void DropDownSelect()
        {
            SelectElement selectElement = new SelectElement(_driver.FindElement((By.XPath("/html/Body/select"))));
            selectElement.SelectByText("test");
            //_mainPage.SortDropDown.SelectByText("Sort by latest");
            _mainPage.OrderByOption(SortOptions.Date);
            var firstElement = WaitAndFindElement(By.XPath("//h2[contains(text(),'Falcon Heavy')]"));
            var firstElementInGrid = WaitAndFindElement(By.XPath("//ul[@class = 'products columns-4']/li/h2[contains(text(),'Falcon Heavy')]"));
            Assert.AreEqual("http://demos.bellatrix.solutions/", _driver.Url);
        }

        private IWebElement WaitAndFindElement(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }
    }
}
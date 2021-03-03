using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverExample.Pages;

namespace WebDriverExample
{
    [TestFixture]
    public class WebmailTests
    {
        private IWebDriver _driver;
        private BluehostMailPage _bluehostMailPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _bluehostMailPage = new BluehostMailPage(_driver);
            _driver.Url = "https://login.bluehost.com/hosting/webmail";
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void Invalid_Login_Should_Fail_Proper_Message_Is_Displayed()
        {
            _bluehostMailPage.loginWithInvalidData();

            var actualPage = WaitAndFindElement(By.XPath("//*[@id='content']/section/form/div/span[1]"));

            Assert.IsTrue(actualPage.Displayed);
        }

        [Test]
        public void Login_With_Empty_Data_Should_Fail_Proper_Message_Is_Displayed()
        {
            _bluehostMailPage.loginWithEmptyData();
            var actualPage = WaitAndFindElement(By.XPath("//*[@id='content']/section/form/div/span[1]"));
            var eMailMsg = WaitAndFindElement(By.XPath("//span[contains(text(),'Email is required.')]"));
            var passwordMsg = WaitAndFindElement(By.XPath("//span[contains(text(),'Password is required.')]"));

            Assert.IsTrue(actualPage.Displayed);
            Assert.IsTrue(eMailMsg.Displayed);
            Assert.IsTrue(passwordMsg.Displayed);
        }

        private IWebElement WaitAndFindElement(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }
    }
}

using Amazon.UI.SeleniumBaseTests.Helpers.Config;
using Amazon.UI.SeleniumBaseTests.Helpers.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Amazon.UI.SeleniumBaseTests.Tests
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;

        protected string BaseURL;

        [SetUp]
        public void SetUp()
        {
            var appConfig = ConfigHelper.Get();
            _driver = DriverFactory.Create(appConfig);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(appConfig.DriverToUse.TimeOuts.ImplicitWait);
            _driver.Navigate().GoToUrl(appConfig.BaseURL);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(appConfig.DriverToUse.TimeOuts.ExplicitWait));
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Close();
        }
    }
}

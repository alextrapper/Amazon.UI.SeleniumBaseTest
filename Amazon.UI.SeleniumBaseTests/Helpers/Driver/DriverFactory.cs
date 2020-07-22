using Amazon.UI.SeleniumBaseTests.Helpers.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Amazon.UI.SeleniumBaseTests.Helpers.Driver
{
    public static class DriverFactory
    {
        public static IWebDriver Create(AppConfig config)
        {
            IWebDriver driver;

            switch (config.DriverToUse.Type)
            {
                case Browser.Chrome:
                    driver = ChromeDriver(config.DriverToUse);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return driver;
        }

        private static ChromeDriver ChromeDriver(DriverToUse driverToUse)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments(driverToUse.Arguments.ToArray());
            return new ChromeDriver(options);
        }
    }
}

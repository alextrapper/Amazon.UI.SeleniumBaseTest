using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Amazon.UI.Common.SeleniumHelpers
{
    public static class DriverActionsHelper
    {
        public static void SendKeysAction(this IWebDriver driver, IWebElement element, string keys)
            => new Actions(driver).SendKeys(element, keys).Build().Perform();
    }
}

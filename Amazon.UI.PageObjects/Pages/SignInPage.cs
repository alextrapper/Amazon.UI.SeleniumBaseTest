using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Amazon.UI.PageObjects.Pages
{
    public class SignInPage
    {
        private const string pageTitle = "Amazon Sign-In";
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public SignInPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public void AssertHeader()
        {
            StringAssert.AreEqualIgnoringCase("Sign-In", Header.Text);
        }

        private IWebElement Header =>
            _wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("h1")));
    }
}

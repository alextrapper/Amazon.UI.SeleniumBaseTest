using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UI.PageObjects.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver _driver;
        protected readonly WebDriverWait _wait;

        protected BasePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }
    }
}

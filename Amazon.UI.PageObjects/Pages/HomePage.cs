using Amazon.UI.PageObjects.PageElements.HomePageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UI.PageObjects.Pages
{
    public class HomePage : BasePage
    {
        private const string _pageTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs & more";

        public HomePage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public SearchBlock Search => new SearchBlock(_driver, _wait);
    }
}
using Amazon.UI.PageObjects.PageElements.ItemPageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UI.PageObjects.Pages
{
    public class ItemPage : HomePage
    {
        public ItemPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public ItemColorSelector ProductColor =>
            new ItemColorSelector(_driver, _wait);

        public BuyBoxControl BuyBox =>
            new BuyBoxControl(_driver, _wait);
    }
}
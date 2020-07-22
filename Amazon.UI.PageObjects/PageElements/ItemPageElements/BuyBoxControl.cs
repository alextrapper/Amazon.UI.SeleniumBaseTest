using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Amazon.UI.PageObjects.PageElements.ItemPageElements
{
    public class BuyBoxControl : BasePage
    {
        public BuyBoxControl(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public SignInPage BuyNow()
        {
            //_wait.Until(ExpectedConditions.StalenessOf(BuyNowButton));
            BuyNowButton.Click();
            return new SignInPage(_driver, _wait);
        }

        private IWebElement BuyNowButton =>
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("buyNow")));
    }
}

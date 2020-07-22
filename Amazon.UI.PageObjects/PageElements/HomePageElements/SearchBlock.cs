using Amazon.UI.Common.SeleniumHelpers;
using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Amazon.UI.PageObjects.PageElements.HomePageElements
{
    public class SearchBlock : BasePage
    {
        public SearchBlock(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void PerformSearch(string searchRequest)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(Submit));
            _driver.SendKeysAction(SearchInput, searchRequest);
            Submit.Click();
        }

        public void AddSentenceToSearch(string sequenceToAdd)
        {
            string existingText = _wait.Until(ExpectedConditions.ElementToBeClickable(SearchInput)).Text;
            _driver.SendKeysAction(SearchInput, $"{existingText} {sequenceToAdd}");
            Submit.Click();
        }

        private IWebElement SearchInput =>
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("twotabsearchtextbox")));

        private IWebElement Submit =>
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#nav-search-submit-text+input")));
    }
}

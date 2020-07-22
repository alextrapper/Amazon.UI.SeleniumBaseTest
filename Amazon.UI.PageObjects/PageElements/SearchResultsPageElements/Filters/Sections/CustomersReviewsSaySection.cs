using Amazon.UI.Common.SeleniumHelpers;
using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.Filters.Sections
{
    public class CustomersReviewsSaySection : BasePage
    {
        public CustomersReviewsSaySection(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public bool IsVisible =>
                _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(
                    By.XPath("//*[@id='filters']//..//span[contains(.,'Customer Reviews Say')]")))
                .Count.Equals(1);

        public void SelectFeatureKeyword(string keyword)
        {
            var itemToCheck = KeywordsList.FirstOrDefault(item => item.Text.Contains(keyword));
            _driver.ScrollIntoCenterViaJS(itemToCheck);
            ((IJavaScriptExecutor)_driver)
                .ExecuteScript($"document.querySelector('[aria-label=\"{ keyword}\"] span span').click()");
        }

        private List<IWebElement> KeywordsList =>
            _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(
                By.CssSelector("#p_n_feature_keywords_six_browse-bin-title+ul")))
            .ToList();
    }
}

using Amazon.UI.Common.SeleniumHelpers;
using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.ResultsList
{
    public class SearchResultsList : BasePage
    {
        public SearchResultsList(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
        public ItemPage OpenItemPage(string itemTitle)
        {
            var itemToOpen = ResultsTitlesList.FirstOrDefault(item => item.Text.Contains(itemTitle));
            itemToOpen?.ScrollIntoCenterViaJS(_driver);
            itemToOpen?.Click();
            return new ItemPage(_driver, _wait);
        }

        private List<IWebElement> ResultsTitlesList =>
            _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(
                By.CssSelector("div[data-component-type='s-search-result'] h2 span")))
            .ToList();
    }
}

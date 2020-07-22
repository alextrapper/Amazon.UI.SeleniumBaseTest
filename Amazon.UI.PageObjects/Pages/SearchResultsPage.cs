using Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.Filters;
using Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.ResultsList;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UI.PageObjects.Pages
{
    public class SearchResultsPage : HomePage
    {
        public SearchResultsPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public FiltersSidePanel Filters =>
            new FiltersSidePanel(_driver, _wait);

        public SearchResultsList SearchResultsList =>
            new SearchResultsList(_driver, _wait);
    }
}

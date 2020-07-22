using Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.Filters.Sections;
using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.Filters
{
    public class FiltersSidePanel : BasePage
    {
        public FiltersSidePanel(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public DepartmentsFilterSection Departments =>
            new DepartmentsFilterSection(_driver, _wait);

        public CustomersReviewsSaySection CustomersReviewsSay =>
            new CustomersReviewsSaySection(_driver, _wait);

    }
}

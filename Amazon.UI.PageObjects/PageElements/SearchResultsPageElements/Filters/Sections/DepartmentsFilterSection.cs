using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.UI.PageObjects.PageElements.SearchResultsPageElements.Filters.Sections
{
    public class DepartmentsFilterSection : BasePage
    {
        public DepartmentsFilterSection(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void SelectDepartment(string departmentName)
        {
            IWebElement departmentToSelect = Departments.FirstOrDefault(item => item.Text.Contains(departmentName));
            if (!departmentToSelect.Enabled)
            {
                ExpandAllDepartments();
            }
            departmentToSelect.Click();
        }

        public void ExpandAllDepartments()
        {
            if (ExpanderPrompt.Text.Contains("See All"))
            {
                ExpanderToggler.Click();
            }
        }

        private List<IWebElement> Departments =>
            _wait.Until(ExpectedConditions
                .PresenceOfAllElementsLocatedBy(By.CssSelector("div#departments li")))
                .ToList();

        private IWebElement ExpanderToggler =>
            _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a[data-action='a-expander-toggle']")));

        private IWebElement ExpanderPrompt =>
            _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".a-expander-prompt")));
    }
}

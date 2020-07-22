using Amazon.UI.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.UI.PageObjects.PageElements.ItemPageElements
{
    public class ItemColorSelector : BasePage
    {
        public ItemColorSelector(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void SelectColor(string itemsColor)
        {
            ProductColors().FirstOrDefault(c =>
                c.GetAttribute("title").Equals($"Click to select {itemsColor}"))
                //.ColorImagePreview
                .Click();
        }

        private List<IWebElement> ProductColors()
        {
            var colors = _wait.Until(ExpectedConditions
                .PresenceOfAllElementsLocatedBy(By.CssSelector("#variation_color_name ul li")));

            return _wait.Until(ExpectedConditions
                .PresenceOfAllElementsLocatedBy(By.CssSelector("#variation_color_name ul li"))).ToList();
        }
    }
}

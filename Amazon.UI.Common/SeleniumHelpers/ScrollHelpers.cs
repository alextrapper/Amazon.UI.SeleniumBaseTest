using OpenQA.Selenium;

namespace Amazon.UI.Common.SeleniumHelpers
{
    public static class ScrollHelpers
    {
        public static void ScrollIntoCenterViaJS(this IWebDriver driver, IWebElement element)
            => ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].scrollIntoView({block: 'center'})", element);

        public static void ScrollIntoCenterViaJS(this IWebElement element, IWebDriver driver)
            => ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].scrollIntoView({block: 'center'})", element);
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ParallelOnlinerTests.Factory;

namespace ParallelOnlinerTests.Elements
{
    public class WebElement
    {
        private readonly By _locator;
        private readonly IWebDriver _driver;

        private Actions Actions => new Actions(_driver);

        public WebElement(IWebDriver driver, By locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public IWebElement InnerWebElement
        {
            get
            {
                WaitForElementIsPresent();
                return _driver.FindElement(_locator);
            }
        }

        public void WaitForElementIsPresent() => DriverFactory.GetWait(_driver, 10).Until(drv => drv.FindElements(_locator).Count > 0);

        public void Click() => InnerWebElement.Click();

        public void SendKeys(string value) => InnerWebElement.SendKeys(value);

        public string GetText() => InnerWebElement.Text;

        public void ScrollToElement() => Actions.MoveToElement(InnerWebElement).Perform();
    }
}

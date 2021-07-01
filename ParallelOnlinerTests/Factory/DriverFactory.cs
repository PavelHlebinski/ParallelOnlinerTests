using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ParallelOnlinerTests.Factory
{
    public class DriverFactory
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public IWebDriver GetDriver() => _driver ??= SetupDriver();

        public IWebDriver SetupDriver() => new ChromeDriver(GetOptions());

        public WebDriverWait GetWait(IWebDriver driver, int timeOutInSeconds) => _wait ??= SetupWait(driver, timeOutInSeconds);

        private static WebDriverWait SetupWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));

        private static ChromeOptions GetOptions()
        {
            var options = new ChromeOptions();
            options.AddArguments("start-maximized");
            return options;
        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ParallelOnlinerTests.Factory
{
    public class DriverFactory
    {
        private IWebDriver _driver;
        private static WebDriverWait _wait;

        public IWebDriver GetDriver() => _driver ??= SetupDriver();

        public IWebDriver SetupDriver() => new ChromeDriver();

        public static WebDriverWait GetWait(IWebDriver driver, int timeOutInSeconds) => _wait ??= SetupWait(driver, timeOutInSeconds);

        private static WebDriverWait SetupWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));

        public static void QuitDriver(IWebDriver driver)
        {
            driver.Quit();
            _wait = null;
        }
    }
}

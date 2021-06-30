using OpenQA.Selenium;
using ParallelOnlinerTests.Factory;
using System;

namespace ParallelOnlinerTests.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver) => Driver = driver;

        public void OpenUrl(string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }

        public void QuitDriver() => DriverFactory.QuitDriver(Driver);
    }
}

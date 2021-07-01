using OpenQA.Selenium;
using ParallelOnlinerTests.Pages.Modules;
using System;

namespace ParallelOnlinerTests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;

        protected BasePage(IWebDriver driver) => Driver = driver;

        protected Header Header => new Header(Driver);

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
    }
}

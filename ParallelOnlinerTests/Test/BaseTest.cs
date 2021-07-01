using NUnit.Framework;
using OpenQA.Selenium;
using ParallelOnlinerTests.Factory;
using ParallelOnlinerTests.Pages.OnlinerPages;

namespace ParallelOnlinerTests.Test
{
    public class BaseTest
    {
        private const string Url = "https://www.onliner.by/";
        protected IWebDriver Driver = new DriverFactory().GetDriver();

        protected MainPage MainPage => new MainPage(Driver);

        protected AutoCatalogPage AutoCatalogPage => new AutoCatalogPage(Driver);

        protected ServicesPage ServicesPage => new ServicesPage(Driver);

        [SetUp]
        public void OpenPage() => MainPage.OpenPage(Url);

        [OneTimeTearDown]
        public void QuitDriver() => Driver.Quit();
    }
}

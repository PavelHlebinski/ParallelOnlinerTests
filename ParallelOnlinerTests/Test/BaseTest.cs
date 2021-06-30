using NUnit.Framework;
using OpenQA.Selenium;
using ParallelOnlinerTests.Factory;
using ParallelOnlinerTests.Pages;
using ParallelOnlinerTests.Pages.OnlinerPages;

namespace ParallelOnlinerTests.Test
{
    public class BaseTest
    {
        protected IWebDriver Driver = new DriverFactory().GetDriver();

        private BasePage BasePage => new BasePage(Driver);

        protected MainPage MainPage => new MainPage(Driver);

        [SetUp]
        public void SetUp() => BasePage.OpenUrl("https://www.onliner.by/");


        [TearDown]
        public void DriverQuit() => BasePage.QuitDriver();
    }
}

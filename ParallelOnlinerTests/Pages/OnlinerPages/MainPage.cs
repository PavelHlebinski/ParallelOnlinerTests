using OpenQA.Selenium;
using ParallelOnlinerTests.Pages.Modules;

namespace ParallelOnlinerTests.Pages.OnlinerPages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        public void OpenPage(string url) => OpenUrl(url);

        public void OpenAutoCatalog() => Header.OpenAutoCatalog();

        public void OpenServices() => Header.OpenServices();
    }
}

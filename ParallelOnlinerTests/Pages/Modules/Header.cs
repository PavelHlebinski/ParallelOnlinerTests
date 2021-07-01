using OpenQA.Selenium;
using ParallelOnlinerTests.Elements;

namespace ParallelOnlinerTests.Pages.Modules
{
    public class Header
    {
        private readonly IWebDriver _driver;

        public Header(IWebDriver driver) => _driver = driver;

        private static string NavLocator(string navigation) => $"//*[@class=\"b-main-navigation__text\"][text()=\"{navigation}\"]";

        private WebElement SearchField => new WebElement(_driver, By.ClassName("fast-search__input"));

        private WebElement NavBar(string navigation) => new WebElement(_driver, By.XPath(NavLocator(navigation)));

        public void OpenAutoCatalog() => NavBar("Автобарахолка").Click();

        public void OpenServices() => NavBar("Услуги").Click();
    }
}

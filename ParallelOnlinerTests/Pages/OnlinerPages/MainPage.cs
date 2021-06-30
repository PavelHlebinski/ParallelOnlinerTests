using OpenQA.Selenium;
using ParallelOnlinerTests.Elements;

namespace ParallelOnlinerTests.Pages.OnlinerPages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        private WebElement Logo =>
            new WebElement(Driver, By.XPath("//*[@id=\"container\"]/div/div/header/div[3]/div/div[1]/a/img"));

        public void LogoClick() => Logo.Click();
    }
}

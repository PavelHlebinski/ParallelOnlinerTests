using NUnit.Framework;
using OpenQA.Selenium;
using ParallelOnlinerTests.Elements;

namespace ParallelOnlinerTests.Pages.OnlinerPages
{
    public class AutoCatalogPage : BasePage
    {
        public AutoCatalogPage(IWebDriver driver) : base(driver) { }

        private static string ModelForSearchLocator(string model) => $"//*[@class=\"dropdown-style__checkbox-sign\"][text()=\"{model}\"]";

        private WebElement Model =>
            new WebElement(Driver, By.XPath("//*[@id=\"container\"]/div/div/div/div/div/div[2]/div/div/div[3]/div/div[2]/div[2]/div[3]/div[4]/div/div[2]/div[1]/div/div/div[1]/div/div[1]/div[2]"));

        private WebElement ModelSearchField =>
            new WebElement(Driver, By.XPath("//*[@placeholder=\"Найти марку\"]"));

        private WebElement FindModel(string model) =>
            new WebElement(Driver, By.XPath(ModelForSearchLocator(model)));

        private WebElement ModelTag =>
            new WebElement(Driver, By.XPath("//*[@id=\"list\"]/div[1]/div/div[1]/div/div/div/div"));

        public void FindAuto(string model)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,100)");
            Model.Click();
            ModelSearchField.SendKeys(model);
            FindModel(model).Click();
        }

        public void CheckModel(string model) => Assert.IsTrue(IsModelCorrect(model));

        private bool IsModelCorrect(string model) => ModelTag.GetText().Contains(model);
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using ParallelOnlinerTests.Elements;

namespace ParallelOnlinerTests.Pages.OnlinerPages
{
    public class ServicesPage : BasePage
    {
        public ServicesPage(IWebDriver driver) : base(driver) { }

        private static string ServicesBarLocator(string serviceName) => $"//*[@class=\"service-form__collapse-header\"]//a[text()=\"{serviceName}\"]";

        private static string ServiceTypeLocator(string serviceType) => $"//*[@class=\"service-form__checkbox-label\"]//*[text()=\"{serviceType}\"]";

        private WebElement SelectService(string serviceName) =>
            new WebElement(Driver, By.XPath(ServicesBarLocator(serviceName)));

        private WebElement SelectServiceType(string serviceType) =>
            new WebElement(Driver, By.XPath(ServiceTypeLocator(serviceType)));

        private WebElement ServiceTag =>
            new WebElement(Driver, By.XPath("//*[@id=\"service-list\"]/div[2]/div/div/div[3]/div/ul/li/div"));

        public void SelectService(string serviceName, string serviceType)
        {
            SelectService(serviceName).Click();
            SelectServiceType(serviceType).Click();
        }

        public void CheckServiceType(string serviceType) => Assert.IsTrue(IsServiceTypeCorrect(serviceType));

        private bool IsServiceTypeCorrect(string serviceType) => ServiceTag.GetText().Contains(serviceType);
    }
}

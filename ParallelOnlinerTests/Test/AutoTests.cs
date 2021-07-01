using NUnit.Framework;

namespace ParallelOnlinerTests.Test
{
    [TestFixture]
    [Parallelizable]
    public class AutoTests : BaseTest
    {
        [TestCase("BMW", TestName = "Find BMW")]
        public void FindBMWTest(string model)
        {
            MainPage.OpenAutoCatalog();
            AutoCatalogPage.FindAuto(model);
            AutoCatalogPage.CheckModel(model);
        }

        [TestCase("Audi", TestName = "Find Audi")]
        public void FindAudiTest(string model)
        {
            MainPage.OpenAutoCatalog();
            AutoCatalogPage.FindAuto(model);
            AutoCatalogPage.CheckModel(model);
        }
    }
}


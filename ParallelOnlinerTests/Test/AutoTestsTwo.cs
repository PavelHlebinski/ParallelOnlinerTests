using NUnit.Framework;

namespace ParallelOnlinerTests.Test
{
    [TestFixture]
    [Parallelizable]
    public class AutoTestsTwo : BaseTest
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

        [TestCase("Opel", TestName = "Find Opel")]
        public void FindOpelTest(string model)
        {
            MainPage.OpenAutoCatalog();
            AutoCatalogPage.FindAuto(model);
            AutoCatalogPage.CheckModel(model);
        }

        [TestCase("Mini", TestName = "Find Mini")]
        public void FindMiniTest(string model)
        {
            MainPage.OpenAutoCatalog();
            AutoCatalogPage.FindAuto(model);
            AutoCatalogPage.CheckModel(model);
        }
    }
}


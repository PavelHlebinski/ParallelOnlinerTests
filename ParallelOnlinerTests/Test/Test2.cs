using NUnit.Framework;

namespace ParallelOnlinerTests.Test
{
    [TestFixture]
    [Parallelizable]
    public class Test2 : BaseTest
    {
        [TestCase]
        public void TestTwo()
        {
            MainPage.LogoClick();
        }
    }
}

using NUnit.Framework;

namespace ParallelOnlinerTests.Test
{
    [TestFixture]
    [Parallelizable]
    public class Test1 : BaseTest
    {
        [TestCase]
        public void TestOne()
        {
            MainPage.LogoClick();
        }
    }
}

